using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IClientsService : IEntityService<Clients>
    {
        Clients GetById(string Id); 

    }
}
