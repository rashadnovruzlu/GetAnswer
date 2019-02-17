using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IClientService : IEntityService<Client>
    {
        Client GetById(string Id); 

    }
}
