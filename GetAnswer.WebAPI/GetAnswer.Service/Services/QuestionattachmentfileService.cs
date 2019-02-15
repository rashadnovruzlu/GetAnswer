using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class QuestionattachmentfileService : EntityService<QuestionAttachmentFile>, IQuestionattachmentfileService
    {
        IUnitOfWork _unitOfWork;
        IQuestionattachmentfileRepository _questionattachmentfileRepository;

        public QuestionattachmentfileService(IUnitOfWork unitOfWork, IQuestionattachmentfileRepository questionattachmentfileRepository)
            : base(unitOfWork, questionattachmentfileRepository)
        {
            _unitOfWork = unitOfWork;
            _questionattachmentfileRepository = questionattachmentfileRepository;
        }
 
        public QuestionAttachmentFile GetById(int Id)
        {
            return _questionattachmentfileRepository.GetById(Id);
        }

        
    }
}
