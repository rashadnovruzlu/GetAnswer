using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using GetAnswer.DTO;
using UtilityLibrary;

namespace GetAnswer.Service
{
    public enum TagType
    {
        Month = 1,
        Week = 2,
        Today = 3
    }

    public class VwTagService : EntityService<VW_TAG>, IVwTagService
    {
        IUnitOfWork _unitOfWork;
        IVwTagRepository _vwtagRepository;

        public VwTagService(IUnitOfWork unitOfWork, IVwTagRepository vwtagRepository)
            : base(unitOfWork, vwtagRepository)
        {
            _unitOfWork = unitOfWork;
            _vwtagRepository = vwtagRepository;
        }
        public VW_TAG GetById(int Id)
        {
            return _vwtagRepository.GetById(Id);
        }


        public List<LetterTag> GetAlphabetical()
        {
            char[] alphabet = LangHelper.GetAzAlphabetLower();

            List<LetterTag> model = new List<LetterTag>();

            var tags = _vwtagRepository.GetAsIQueryable().ToList();


            foreach (char letter in alphabet)
            {
                var rows = tags.Where(x => x.Name[0] == letter);

                var distinctTags = rows.Select(x => new { x.Id, x.Name, x.FullCount }).Distinct();

                LetterTag letterTag = new LetterTag() { Letter = letter, Tags = new List<TagDTO>() };

                foreach (var item in distinctTags)
                {
                    var month = rows.Where(x => x.Id == item.Id && x.Type == (byte)TagType.Month).FirstOrDefault();

                    var week = rows.Where(x => x.Id == item.Id && x.Type == (byte)TagType.Week).FirstOrDefault();

                    var today = rows.Where(x => x.Id == item.Id && x.Type == (byte)TagType.Today).FirstOrDefault();

                    TagDTO tag = new TagDTO()
                    {
                        Id = item.Id,
                        Name = item.Name,
                        Count = item.FullCount,
                        Month = month != null ? month.Count : 0,
                        Week = week != null ? week.Count : 0,
                        Today = today != null ? today.Count : 0
                    };

                    letterTag.Tags.Add(tag);
                }

                model.Add(letterTag);
            }

            return model;
        }



        public List<TagDTO> GetPopular()
        {
            List<TagDTO> model = new List<TagDTO>();

            var tags = _vwtagRepository.GetAsIQueryable().ToList();

            var distinctTags = tags.Select(x => new { x.Id, x.Name, x.FullCount }).Distinct();

            foreach (var item in distinctTags)
            {

                var month = tags.Where(x => x.Id == item.Id && x.Type == (byte)TagType.Month).FirstOrDefault();

                var week = tags.Where(x => x.Id == item.Id && x.Type == (byte)TagType.Week).FirstOrDefault();

                var today = tags.Where(x => x.Id == item.Id && x.Type == (byte)TagType.Today).FirstOrDefault();

                TagDTO tag = new TagDTO()
                {
                    Id = item.Id,
                    Name = item.Name,
                    Count = item.FullCount,
                    Month = month != null ? month.Count : 0,
                    Week = week != null ? week.Count : 0,
                    Today = today != null ? today.Count : 0
                };

                model.Add(tag);
            }

            return model.OrderBy(x => x.Count).ToList();
        }
    }
}
