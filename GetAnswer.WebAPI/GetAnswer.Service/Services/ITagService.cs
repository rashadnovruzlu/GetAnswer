using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface ITagService : IEntityService<Tag>
    {
        Tag GetById(int Id); 

    }
}
