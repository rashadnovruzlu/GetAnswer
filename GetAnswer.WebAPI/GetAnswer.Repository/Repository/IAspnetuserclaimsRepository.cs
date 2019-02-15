using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IAspnetuserclaimsRepository : IGenericRepository<AspNetUserClaims>
    {
        AspNetUserClaims GetById(string id);
    }
}
