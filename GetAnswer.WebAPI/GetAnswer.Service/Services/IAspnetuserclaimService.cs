using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IAspnetuserclaimService : IEntityService<AspNetUserClaim>
    {
        AspNetUserClaim GetById(int Id); 

    }
}
