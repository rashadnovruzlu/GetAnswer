using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface ICountyService : IEntityService<County>
    {
        County GetById(int Id); 

    }
}
