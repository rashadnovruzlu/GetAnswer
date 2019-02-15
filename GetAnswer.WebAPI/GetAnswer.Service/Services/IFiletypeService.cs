using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IFiletypeService : IEntityService<FileType>
    {
        FileType GetById(string Id); 

    }
}
