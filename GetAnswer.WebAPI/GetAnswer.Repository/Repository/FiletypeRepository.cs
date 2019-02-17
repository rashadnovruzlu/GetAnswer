using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class FiletypeRepository : GenericRepository<FileType>, IFiletypeRepository
    {
        public FiletypeRepository(DbContext context) : base(context)
        {

        }
         

        public FileType GetById(int id)
        {
            return _dbset.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
