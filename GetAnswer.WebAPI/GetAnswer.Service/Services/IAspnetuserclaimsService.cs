using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IAspnetuserclaimsService : IEntityService<AspNetUserClaims>
    {
        AspNetUserClaims GetById(string Id); 

    }
}
