using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class UserinteresttagService : EntityService<UserInterestTag>, IUserinteresttagService
    {
        IUnitOfWork _unitOfWork;
        IUserinteresttagRepository _userinteresttagRepository;

        public UserinteresttagService(IUnitOfWork unitOfWork, IUserinteresttagRepository userinteresttagRepository)
            : base(unitOfWork, userinteresttagRepository)
        {
            _unitOfWork = unitOfWork;
            _userinteresttagRepository = userinteresttagRepository;
        }
 
        public UserInterestTag GetById(int Id)
        {
            return _userinteresttagRepository.GetById(Id);
        }

        
    }
}
