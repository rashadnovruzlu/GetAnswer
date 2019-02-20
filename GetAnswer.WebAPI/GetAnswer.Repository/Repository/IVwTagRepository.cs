using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IVwTagRepository : IGenericRepository<VW_TAG>
    {
        VW_TAG GetById(int id);
    }
}
