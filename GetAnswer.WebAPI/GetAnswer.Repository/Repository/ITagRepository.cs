using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface ITagRepository : IGenericRepository<Tag>
    {
        Tag GetById(int id);
    }
}
