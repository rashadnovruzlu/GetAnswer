using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IAspnetuserloginRepository : IGenericRepository<AspNetUserLogin>
    {
        AspNetUserLogin GetById(string id);
    }
}
