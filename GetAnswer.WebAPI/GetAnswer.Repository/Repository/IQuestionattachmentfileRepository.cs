using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IQuestionattachmentfileRepository : IGenericRepository<QuestionAttachmentFile>
    {
        QuestionAttachmentFile GetById(int id);
    }
}
