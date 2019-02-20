using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class VwTagRepository : GenericRepository<VW_TAG>, IVwTagRepository
    {
        public VwTagRepository(DbContext context) : base(context)
        {

        }
         

        public VW_TAG GetById(int id)
        {
            return _dbset.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
