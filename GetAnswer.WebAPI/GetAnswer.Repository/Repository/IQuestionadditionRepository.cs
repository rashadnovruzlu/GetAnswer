using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IQuestionadditionRepository : IGenericRepository<QuestionAddition>
    {
        QuestionAddition GetById(int id);
    }
}
