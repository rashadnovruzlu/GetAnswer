using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IQuestionRepository : IGenericRepository<Question>
    {
        Question GetById(int id);
    }
}
