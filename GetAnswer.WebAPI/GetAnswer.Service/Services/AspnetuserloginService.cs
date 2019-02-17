using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class AspnetuserloginService : EntityService<AspNetUserLogin>, IAspnetuserloginService
    {
        IUnitOfWork _unitOfWork;
        IAspnetuserloginRepository _aspnetuserloginRepository;

        public AspnetuserloginService(IUnitOfWork unitOfWork, IAspnetuserloginRepository aspnetuserloginRepository)
            : base(unitOfWork, aspnetuserloginRepository)
        {
            _unitOfWork = unitOfWork;
            _aspnetuserloginRepository = aspnetuserloginRepository;
        }
 
        public AspNetUserLogin GetById(string Id)
        {
            return _aspnetuserloginRepository.GetById(Id);
        }

        
    }
}
