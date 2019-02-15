using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(DbContext context) : base(context)
        {

        }
         

        public Category GetById(string id)
        {
            return _dbset.Where(x => x.Category1 == id).FirstOrDefault();
        }
    }
}
