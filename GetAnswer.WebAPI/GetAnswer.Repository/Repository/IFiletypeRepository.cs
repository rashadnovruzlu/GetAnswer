using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IFiletypeRepository : IGenericRepository<FileType>
    {
        FileType GetById(int id);
    }
}
