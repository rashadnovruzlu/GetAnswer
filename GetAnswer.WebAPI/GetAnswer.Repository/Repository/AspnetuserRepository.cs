using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class AspnetuserRepository : GenericRepository<AspNetUser>, IAspnetuserRepository
    {
        public AspnetuserRepository(DbContext context) : base(context)
        {

        }
         

        public AspNetUser GetById(string id)
        {
            return _dbset.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
