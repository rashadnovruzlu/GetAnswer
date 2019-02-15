using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class AspnetusersRepository : GenericRepository<AspNetUsers>, IAspnetusersRepository
    {
        public AspnetusersRepository(DbContext context) : base(context)
        {

        }
         

        public AspNetUsers GetById(byte id)
        {
            return _dbset.Where(x => x.Level == id).FirstOrDefault();
        }
    }
}
