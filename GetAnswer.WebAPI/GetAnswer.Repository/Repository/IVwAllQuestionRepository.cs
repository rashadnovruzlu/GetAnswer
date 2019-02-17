using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IVwAllQuestionRepository : IGenericRepository<VW_ALL_QUESTION>
    {
        VW_ALL_QUESTION GetById(int id);
    }
}
