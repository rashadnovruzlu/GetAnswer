using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class AspnetuserclaimsRepository : GenericRepository<AspNetUserClaims>, IAspnetuserclaimsRepository
    {
        public AspnetuserclaimsRepository(DbContext context) : base(context)
        {

        }
         

        public AspNetUserClaims GetById(string id)
        {
            return _dbset.Where(x => x.UserId == id).FirstOrDefault();
        }
    }
}
