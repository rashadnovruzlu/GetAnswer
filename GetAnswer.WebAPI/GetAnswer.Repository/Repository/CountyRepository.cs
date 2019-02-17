using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class CountyRepository : GenericRepository<County>, ICountyRepository
    {
        public CountyRepository(DbContext context) : base(context)
        {

        }
         

        public County GetById(int id)
        {
            return _dbset.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
