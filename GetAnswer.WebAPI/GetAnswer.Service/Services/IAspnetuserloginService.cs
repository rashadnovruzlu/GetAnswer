using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IAspnetuserloginService : IEntityService<AspNetUserLogin>
    {
        AspNetUserLogin GetById(string Id); 

    }
}
