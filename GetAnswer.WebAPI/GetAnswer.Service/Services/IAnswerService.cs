using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IAnswerService : IEntityService<Answer>
    {
        Answer GetById(int Id); 

    }
}
