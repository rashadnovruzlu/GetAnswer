using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IAspnetroleService : IEntityService<AspNetRole>
    {
        AspNetRole GetById(string Id); 

    }
}
