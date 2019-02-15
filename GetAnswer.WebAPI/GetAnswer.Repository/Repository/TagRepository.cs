using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(DbContext context) : base(context)
        {

        }
         

        public Tag GetById(int id)
        {
            return _dbset.Where(x => x.CategoryId == id).FirstOrDefault();
        }
    }
}
