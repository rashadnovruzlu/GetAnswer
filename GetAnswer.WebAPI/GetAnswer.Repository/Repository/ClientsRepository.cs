using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class ClientsRepository : GenericRepository<Clients>, IClientsRepository
    {
        public ClientsRepository(DbContext context) : base(context)
        {

        }
         

        public Clients GetById(string id)
        {
            return _dbset.Where(x => x.Secret == id).FirstOrDefault();
        }
    }
}
