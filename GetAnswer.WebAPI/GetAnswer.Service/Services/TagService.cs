using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using GetAnswer.DTO;

namespace GetAnswer.Service
{
    public class TagService : EntityService<Tag>, ITagService
    {
        IUnitOfWork _unitOfWork;
        ITagRepository _tagRepository;

        public TagService(IUnitOfWork unitOfWork, ITagRepository tagRepository)
            : base(unitOfWork, tagRepository)
        {
            _unitOfWork = unitOfWork;
            _tagRepository = tagRepository;
        }

        public int Count()
        {
            return _tagRepository.GetAsIQueryable().Count();
        }

        public Tag GetById(int Id)
        {
            return _tagRepository.GetById(Id);
        }

        public List<NameCountDTO> GetMostUsedTag()
        {
            return _tagRepository.GetAsIQueryable().OrderByDescending(x => x.Count)
                                 .Select(x => new NameCountDTO
                                 { Id = x.Id.ToString(), Name = x.Name, Count = x.Count }).Take(8).ToList();
        }
    }
}
