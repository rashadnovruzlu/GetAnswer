using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class AspnetuserclaimsService : EntityService<AspNetUserClaims>, IAspnetuserclaimsService
    {
        IUnitOfWork _unitOfWork;
        IAspnetuserclaimsRepository _aspnetuserclaimsRepository;

        public AspnetuserclaimsService(IUnitOfWork unitOfWork, IAspnetuserclaimsRepository aspnetuserclaimsRepository)
            : base(unitOfWork, aspnetuserclaimsRepository)
        {
            _unitOfWork = unitOfWork;
            _aspnetuserclaimsRepository = aspnetuserclaimsRepository;
        }
 
        public AspNetUserClaims GetById(string Id)
        {
            return _aspnetuserclaimsRepository.GetById(Id);
        }

        
    }
}
