using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IUserinfoService : IEntityService<UserInfo>
    {
        UserInfo GetById(string Id); 

    }
}
