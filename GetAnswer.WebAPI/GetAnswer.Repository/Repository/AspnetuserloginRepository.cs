using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class AspnetuserloginRepository : GenericRepository<AspNetUserLogin>, IAspnetuserloginRepository
    {
        public AspnetuserloginRepository(DbContext context) : base(context)
        {

        }
         

        public AspNetUserLogin GetById(string id)
        {
            return _dbset.Where(x => x.LoginProvider == id).FirstOrDefault();
        }
    }
}
