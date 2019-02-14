namespace GetAnswer.Repository
{
    public interface IUnitOfWork
    {
        int Commit();
    }
}