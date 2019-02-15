using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class DoctoratedegreeService : EntityService<DoctorateDegree>, IDoctoratedegreeService
    {
        IUnitOfWork _unitOfWork;
        IDoctoratedegreeRepository _doctoratedegreeRepository;

        public DoctoratedegreeService(IUnitOfWork unitOfWork, IDoctoratedegreeRepository doctoratedegreeRepository)
            : base(unitOfWork, doctoratedegreeRepository)
        {
            _unitOfWork = unitOfWork;
            _doctoratedegreeRepository = doctoratedegreeRepository;
        }
 
        public DoctorateDegree GetById(string Id)
        {
            return _doctoratedegreeRepository.GetById(Id);
        }

        
    }
}
