using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class AspnetuserService : EntityService<AspNetUser>, IAspnetuserService
    {
        IUnitOfWork _unitOfWork;
        IAspnetuserRepository _aspnetuserRepository;

        public AspnetuserService(IUnitOfWork unitOfWork, IAspnetuserRepository aspnetuserRepository)
            : base(unitOfWork, aspnetuserRepository)
        {
            _unitOfWork = unitOfWork;
            _aspnetuserRepository = aspnetuserRepository;
        }
 
        public AspNetUser GetById(string Id)
        {
            return _aspnetuserRepository.GetById(Id);
        }

        
    }
}
