using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class AspnetuserloginsRepository : GenericRepository<AspNetUserLogins>, IAspnetuserloginsRepository
    {
        public AspnetuserloginsRepository(DbContext context) : base(context)
        {

        }
         

        public AspNetUserLogins GetById(string id)
        {
            return _dbset.Where(x => x.LoginProvider == id).FirstOrDefault();
        }
    }
}
