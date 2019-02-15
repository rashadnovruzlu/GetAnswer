using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IQuestionadditionService : IEntityService<QuestionAddition>
    {
        QuestionAddition GetById(int Id); 

    }
}
