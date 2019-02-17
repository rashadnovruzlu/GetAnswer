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
         

        public DoctorateDegree GetById(byte id)
        {
            return _dbset.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
