using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IAspnetuserloginsService : IEntityService<AspNetUserLogins>
    {
        AspNetUserLogins GetById(string Id); 

    }
}
