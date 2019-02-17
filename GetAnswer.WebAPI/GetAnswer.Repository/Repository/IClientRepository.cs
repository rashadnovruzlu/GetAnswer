using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        Client GetById(string id);
    }
}
