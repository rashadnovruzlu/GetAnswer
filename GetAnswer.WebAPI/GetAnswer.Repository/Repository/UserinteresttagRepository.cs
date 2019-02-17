using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class UserinteresttagRepository : GenericRepository<UserInterestTag>, IUserinteresttagRepository
    {
        public UserinteresttagRepository(DbContext context) : base(context)
        {

        }
         

        public UserInterestTag GetById(int id)
        {
            return _dbset.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
