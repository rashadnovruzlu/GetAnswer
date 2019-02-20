using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;
using GetAnswer.DTO;

namespace GetAnswer.Service
{
    public interface IVwTagService : IEntityService<VW_TAG>
    {
        VW_TAG GetById(int Id);
        List<LetterTag> GetAlphabetical();
        List<TagDTO> GetPopular();

    }
}
