using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class AspnetroleRepository : GenericRepository<AspNetRole>, IAspnetroleRepository
    {
        public AspnetroleRepository(DbContext context) : base(context)
        {

        }
         

        public AspNetRole GetById(string id)
        {
            return _dbset.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
