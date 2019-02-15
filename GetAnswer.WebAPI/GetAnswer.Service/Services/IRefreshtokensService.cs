using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IRefreshtokensService : IEntityService<RefreshTokens>
    {
        RefreshTokens GetById(string Id); 

    }
}
