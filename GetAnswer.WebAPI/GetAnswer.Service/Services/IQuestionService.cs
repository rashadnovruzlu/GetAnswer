using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IQuestionService : IEntityService<Question>
    {
        Question GetById(int Id); 

    }
}
