using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IUserinfoRepository : IGenericRepository<UserInfo>
    {
        UserInfo GetById(string id);
    }
}
