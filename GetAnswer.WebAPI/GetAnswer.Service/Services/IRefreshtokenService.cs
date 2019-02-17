using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IRefreshtokenService : IEntityService<RefreshToken>
    {
        RefreshToken GetById(string Id); 

    }
}
