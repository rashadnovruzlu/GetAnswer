using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class RefreshtokenRepository : GenericRepository<RefreshToken>, IRefreshtokenRepository
    {
        public RefreshtokenRepository(DbContext context) : base(context)
        {

        }
         

        public RefreshToken GetById(string id)
        {
            return _dbset.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
