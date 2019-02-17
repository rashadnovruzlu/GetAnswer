using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class CountyService : EntityService<County>, ICountyService
    {
        IUnitOfWork _unitOfWork;
        ICountyRepository _countyRepository;

        public CountyService(IUnitOfWork unitOfWork, ICountyRepository countyRepository)
            : base(unitOfWork, countyRepository)
        {
            _unitOfWork = unitOfWork;
            _countyRepository = countyRepository;
        }
 
        public County GetById(int Id)
        {
            return _countyRepository.GetById(Id);
        }

        
    }
}
