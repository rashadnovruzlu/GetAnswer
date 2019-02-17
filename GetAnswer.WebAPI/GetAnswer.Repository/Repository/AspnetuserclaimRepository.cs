using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class AspnetuserclaimRepository : GenericRepository<AspNetUserClaim>, IAspnetuserclaimRepository
    {
        public AspnetuserclaimRepository(DbContext context) : base(context)
        {

        }
         

        public AspNetUserClaim GetById(int id)
        {
            return _dbset.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
