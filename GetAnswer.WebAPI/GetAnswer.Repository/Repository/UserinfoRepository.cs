using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class UserinfoRepository : GenericRepository<UserInfo>, IUserinfoRepository
    {
        public UserinfoRepository(DbContext context) : base(context)
        {

        }
         

        public UserInfo GetById(string id)
        {
            return _dbset.Where(x => x.UserId == id).FirstOrDefault();
        }
    }
}
