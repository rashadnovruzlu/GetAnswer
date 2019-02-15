using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IClientsRepository : IGenericRepository<Clients>
    {
        Clients GetById(string id);
    }
}
