using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface ICommentService : IEntityService<Comment>
    {
        Comment GetById(int Id); 

    }
}
