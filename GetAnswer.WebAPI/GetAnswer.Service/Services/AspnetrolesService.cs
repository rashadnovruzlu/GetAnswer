using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class AspnetrolesService : EntityService<AspNetRoles>, IAspnetrolesService
    {
        IUnitOfWork _unitOfWork;
        IAspnetrolesRepository _aspnetrolesRepository;

        public AspnetrolesService(IUnitOfWork unitOfWork, IAspnetrolesRepository aspnetrolesRepository)
            : base(unitOfWork, aspnetrolesRepository)
        {
            _unitOfWork = unitOfWork;
            _aspnetrolesRepository = aspnetrolesRepository;
        }
 
        public AspNetRoles GetById(string Id)
        {
            return _aspnetrolesRepository.GetById(Id);
        }

        
    }
}
