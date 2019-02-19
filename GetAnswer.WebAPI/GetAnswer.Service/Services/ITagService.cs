using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;
using GetAnswer.DTO;

namespace GetAnswer.Service
{
    public interface ITagService : IEntityService<Tag>
    {
        Tag GetById(int Id);
        List<NameCountDTO> GetMostUsedTag();
    }
}
