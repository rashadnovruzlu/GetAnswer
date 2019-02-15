using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class QuestionService : EntityService<Question>, IQuestionService
    {
        IUnitOfWork _unitOfWork;
        IQuestionRepository _questionRepository;

        public QuestionService(IUnitOfWork unitOfWork, IQuestionRepository questionRepository)
            : base(unitOfWork, questionRepository)
        {
            _unitOfWork = unitOfWork;
            _questionRepository = questionRepository;
        }
 
        public Question GetById(int Id)
        {
            return _questionRepository.GetById(Id);
        }

        
    }
}
