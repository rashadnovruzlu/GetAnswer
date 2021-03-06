using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface ICityService : IEntityService<City>
    {
        City GetById(int Id); 

    }
}
