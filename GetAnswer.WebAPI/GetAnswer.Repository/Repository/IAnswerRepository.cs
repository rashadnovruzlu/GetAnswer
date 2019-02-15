using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IAnswerRepository : IGenericRepository<Answer>
    {
        Answer GetById(int id);
    }
}
