using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IAspnetuserclaimRepository : IGenericRepository<AspNetUserClaim>
    {
        AspNetUserClaim GetById(int id);
    }
}
