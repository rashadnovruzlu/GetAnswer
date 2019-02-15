using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IRefreshtokensRepository : IGenericRepository<RefreshTokens>
    {
        RefreshTokens GetById(string id);
    }
}
