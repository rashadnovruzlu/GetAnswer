using GetAnswer.Model;
using System.Data.Entity;
using System.Linq;

namespace GetAnswer.Repository
{
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(DbContext context) : base(context)
        {

        }
         

        public Client GetById(string id)
        {
            return _dbset.Where(x => x.Id == id).FirstOrDefault();
        }
    }
}
