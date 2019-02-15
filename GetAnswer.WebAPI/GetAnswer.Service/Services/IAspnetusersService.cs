using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IAspnetusersService : IEntityService<AspNetUsers>
    {
        AspNetUsers GetById(byte Id); 

    }
}
