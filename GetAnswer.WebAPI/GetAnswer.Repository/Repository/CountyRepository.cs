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
         

        public County GetById(string id)
        {
            return _dbset.Where(x => x.CountryName == id).FirstOrDefault();
        }
    }
}
