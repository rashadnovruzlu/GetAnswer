using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IUserinteresttagRepository : IGenericRepository<UserInterestTag>
    {
        UserInterestTag GetById(int id);
    }
}
