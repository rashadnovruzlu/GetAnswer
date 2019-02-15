using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class AspnetuserloginsService : EntityService<AspNetUserLogins>, IAspnetuserloginsService
    {
        IUnitOfWork _unitOfWork;
        IAspnetuserloginsRepository _aspnetuserloginsRepository;

        public AspnetuserloginsService(IUnitOfWork unitOfWork, IAspnetuserloginsRepository aspnetuserloginsRepository)
            : base(unitOfWork, aspnetuserloginsRepository)
        {
            _unitOfWork = unitOfWork;
            _aspnetuserloginsRepository = aspnetuserloginsRepository;
        }
 
        public AspNetUserLogins GetById(string Id)
        {
            return _aspnetuserloginsRepository.GetById(Id);
        }

        
    }
}
