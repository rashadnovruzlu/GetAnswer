using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class RefreshtokenService : EntityService<RefreshToken>, IRefreshtokenService
    {
        IUnitOfWork _unitOfWork;
        IRefreshtokenRepository _refreshtokenRepository;

        public RefreshtokenService(IUnitOfWork unitOfWork, IRefreshtokenRepository refreshtokenRepository)
            : base(unitOfWork, refreshtokenRepository)
        {
            _unitOfWork = unitOfWork;
            _refreshtokenRepository = refreshtokenRepository;
        }
 
        public RefreshToken GetById(string Id)
        {
            return _refreshtokenRepository.GetById(Id);
        }

        
    }
}
