using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        Category GetById(string id);
    }
}
