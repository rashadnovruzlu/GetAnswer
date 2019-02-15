using GetAnswer.Service.EntityService;
using GetAnswer.Model;
using System.Collections.Generic;

namespace GetAnswer.Service
{
    public interface IDoctoratedegreeService : IEntityService<DoctorateDegree>
    {
        DoctorateDegree GetById(string Id); 

    }
}
