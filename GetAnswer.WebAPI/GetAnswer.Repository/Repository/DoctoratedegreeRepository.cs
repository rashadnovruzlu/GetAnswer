using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class DoctoratedegreeRepository : GenericRepository<DoctorateDegree>, IDoctoratedegreeRepository
    {
        public DoctoratedegreeRepository(DbContext context) : base(context)
        {

        }
         

        public DoctorateDegree GetById(string id)
        {
            return _dbset.Where(x => x.Name == id).FirstOrDefault();
        }
    }
}
