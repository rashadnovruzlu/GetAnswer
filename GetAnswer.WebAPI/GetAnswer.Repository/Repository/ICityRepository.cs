using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface ICityRepository : IGenericRepository<City>
    {
        City GetById(int id);
    }
}
