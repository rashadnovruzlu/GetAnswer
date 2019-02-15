using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IUserinteresttagService : IEntityService<UserInterestTag>
    {
        UserInterestTag GetById(int Id); 

    }
}
