using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IAspnetroleRepository : IGenericRepository<AspNetRole>
    {
        AspNetRole GetById(string id);
    }
}
