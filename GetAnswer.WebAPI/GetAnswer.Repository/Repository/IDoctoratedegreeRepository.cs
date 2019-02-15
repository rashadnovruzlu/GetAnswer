using GetAnswer.Model;

namespace GetAnswer.Repository
{
    public interface IDoctoratedegreeRepository : IGenericRepository<DoctorateDegree>
    {
        DoctorateDegree GetById(string id);
    }
}
