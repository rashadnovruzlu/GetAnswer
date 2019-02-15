using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IAspnetrolesRepository : IGenericRepository<AspNetRoles>
    {
        AspNetRoles GetById(string id);
    }
}
