using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface ICommentRepository : IGenericRepository<Comment>
    {
        Comment GetById(int id);
    }
}
