using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

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
 
        public Tag GetById(int Id)
        {
            return _tagRepository.GetById(Id);
        }

        
    }
}
