using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class AnswerService : EntityService<Answer>, IAnswerService
    {
        IUnitOfWork _unitOfWork;
        IAnswerRepository _answerRepository;

        public AnswerService(IUnitOfWork unitOfWork, IAnswerRepository answerRepository)
            : base(unitOfWork, answerRepository)
        {
            _unitOfWork = unitOfWork;
            _answerRepository = answerRepository;
        }
 
        public Answer GetById(int Id)
        {
            return _answerRepository.GetById(Id);
        }

        
    }
}
