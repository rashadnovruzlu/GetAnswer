using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class UserinfoService : EntityService<UserInfo>, IUserinfoService
    {
        IUnitOfWork _unitOfWork;
        IUserinfoRepository _userinfoRepository;

        public UserinfoService(IUnitOfWork unitOfWork, IUserinfoRepository userinfoRepository)
            : base(unitOfWork, userinfoRepository)
        {
            _unitOfWork = unitOfWork;
            _userinfoRepository = userinfoRepository;
        }
 
        public UserInfo GetById(string Id)
        {
            return _userinfoRepository.GetById(Id);
        }

        
    }
}
