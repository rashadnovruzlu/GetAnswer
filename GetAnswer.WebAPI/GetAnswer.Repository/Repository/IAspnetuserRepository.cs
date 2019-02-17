using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IAspnetuserRepository : IGenericRepository<AspNetUser>
    {
        AspNetUser GetById(string id);
    }
}
