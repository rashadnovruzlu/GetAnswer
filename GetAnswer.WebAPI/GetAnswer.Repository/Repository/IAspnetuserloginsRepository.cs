using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IAspnetuserloginsRepository : IGenericRepository<AspNetUserLogins>
    {
        AspNetUserLogins GetById(string id);
    }
}
