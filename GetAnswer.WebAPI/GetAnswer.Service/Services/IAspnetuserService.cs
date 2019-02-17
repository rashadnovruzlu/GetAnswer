using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IAspnetuserService : IEntityService<AspNetUser>
    {
        AspNetUser GetById(string Id); 

    }
}
