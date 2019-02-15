using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class QuestionadditionService : EntityService<QuestionAddition>, IQuestionadditionService
    {
        IUnitOfWork _unitOfWork;
        IQuestionadditionRepository _questionadditionRepository;

        public QuestionadditionService(IUnitOfWork unitOfWork, IQuestionadditionRepository questionadditionRepository)
            : base(unitOfWork, questionadditionRepository)
        {
            _unitOfWork = unitOfWork;
            _questionadditionRepository = questionadditionRepository;
        }
 
        public QuestionAddition GetById(int Id)
        {
            return _questionadditionRepository.GetById(Id);
        }

        
    }
}
