using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class AspnetroleService : EntityService<AspNetRole>, IAspnetroleService
    {
        IUnitOfWork _unitOfWork;
        IAspnetroleRepository _aspnetroleRepository;

        public AspnetroleService(IUnitOfWork unitOfWork, IAspnetroleRepository aspnetroleRepository)
            : base(unitOfWork, aspnetroleRepository)
        {
            _unitOfWork = unitOfWork;
            _aspnetroleRepository = aspnetroleRepository;
        }
 
        public AspNetRole GetById(string Id)
        {
            return _aspnetroleRepository.GetById(Id);
        }

        
    }
}
