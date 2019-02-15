using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class AspnetrolesRepository : GenericRepository<AspNetRoles>, IAspnetrolesRepository
    {
        public AspnetrolesRepository(DbContext context) : base(context)
        {

        }
         

        public AspNetRoles GetById(string id)
        {
            return _dbset.Where(x => x.Name == id).FirstOrDefault();
        }
    }
}
