using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class RefreshtokensRepository : GenericRepository<RefreshTokens>, IRefreshtokensRepository
    {
        public RefreshtokensRepository(DbContext context) : base(context)
        {

        }
         

        public RefreshTokens GetById(string id)
        {
            return _dbset.Where(x => x.Subject == id).FirstOrDefault();
        }
    }
}
