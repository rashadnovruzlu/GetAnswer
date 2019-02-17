using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IVwAllQuestionService : IEntityService<VW_ALL_QUESTION>
    {
        VW_ALL_QUESTION GetById(int Id); 

    }
}
