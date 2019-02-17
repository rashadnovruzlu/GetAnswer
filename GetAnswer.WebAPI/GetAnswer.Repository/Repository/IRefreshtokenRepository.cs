using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IRefreshtokenRepository : IGenericRepository<RefreshToken>
    {
        RefreshToken GetById(string id);
    }
}
