using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IAspnetusersRepository : IGenericRepository<AspNetUsers>
    {
        AspNetUsers GetById(byte id);
    }
}
