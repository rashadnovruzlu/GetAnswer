using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface ICategoryService : IEntityService<Category>
    {
        Category GetById(int Id); 

    }
}
