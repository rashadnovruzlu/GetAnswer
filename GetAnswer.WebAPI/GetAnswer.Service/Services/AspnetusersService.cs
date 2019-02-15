using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class AspnetusersService : EntityService<AspNetUsers>, IAspnetusersService
    {
        IUnitOfWork _unitOfWork;
        IAspnetusersRepository _aspnetusersRepository;

        public AspnetusersService(IUnitOfWork unitOfWork, IAspnetusersRepository aspnetusersRepository)
            : base(unitOfWork, aspnetusersRepository)
        {
            _unitOfWork = unitOfWork;
            _aspnetusersRepository = aspnetusersRepository;
        }
 
        public AspNetUsers GetById(byte Id)
        {
            return _aspnetusersRepository.GetById(Id);
        }

        
    }
}
