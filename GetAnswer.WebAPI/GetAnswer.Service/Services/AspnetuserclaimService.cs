using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class AspnetuserclaimService : EntityService<AspNetUserClaim>, IAspnetuserclaimService
    {
        IUnitOfWork _unitOfWork;
        IAspnetuserclaimRepository _aspnetuserclaimRepository;

        public AspnetuserclaimService(IUnitOfWork unitOfWork, IAspnetuserclaimRepository aspnetuserclaimRepository)
            : base(unitOfWork, aspnetuserclaimRepository)
        {
            _unitOfWork = unitOfWork;
            _aspnetuserclaimRepository = aspnetuserclaimRepository;
        }
 
        public AspNetUserClaim GetById(int Id)
        {
            return _aspnetuserclaimRepository.GetById(Id);
        }

        
    }
}
