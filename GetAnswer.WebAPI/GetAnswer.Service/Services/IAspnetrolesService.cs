using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IAspnetrolesService : IEntityService<AspNetRoles>
    {
        AspNetRoles GetById(string Id); 

    }
}
