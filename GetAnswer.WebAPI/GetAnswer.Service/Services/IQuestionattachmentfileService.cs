using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IQuestionattachmentfileService : IEntityService<QuestionAttachmentFile>
    {
        QuestionAttachmentFile GetById(int Id); 

    }
}
