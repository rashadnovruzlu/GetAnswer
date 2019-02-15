using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class RefreshtokensService : EntityService<RefreshTokens>, IRefreshtokensService
    {
        IUnitOfWork _unitOfWork;
        IRefreshtokensRepository _refreshtokensRepository;

        public RefreshtokensService(IUnitOfWork unitOfWork, IRefreshtokensRepository refreshtokensRepository)
            : base(unitOfWork, refreshtokensRepository)
        {
            _unitOfWork = unitOfWork;
            _refreshtokensRepository = refreshtokensRepository;
        }
 
        public RefreshTokens GetById(string Id)
        {
            return _refreshtokensRepository.GetById(Id);
        }

        
    }
}
