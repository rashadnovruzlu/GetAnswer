using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class VwAllQuestionService : EntityService<VW_ALL_QUESTION>, IVwAllQuestionService
    {
        IUnitOfWork _unitOfWork;
        IVwAllQuestionRepository _vwallquestionRepository;

        public VwAllQuestionService(IUnitOfWork unitOfWork, IVwAllQuestionRepository vwallquestionRepository)
            : base(unitOfWork, vwallquestionRepository)
        {
            _unitOfWork = unitOfWork;
            _vwallquestionRepository = vwallquestionRepository;
        }
 
        public VW_ALL_QUESTION GetById(int Id)
        {
            return _vwallquestionRepository.GetById(Id);
        }

        
    }
}
