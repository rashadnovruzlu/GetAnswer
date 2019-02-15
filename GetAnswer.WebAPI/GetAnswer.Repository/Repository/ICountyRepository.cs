using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface ICountyRepository : IGenericRepository<County>
    {
        County GetById(string id);
    }
}
