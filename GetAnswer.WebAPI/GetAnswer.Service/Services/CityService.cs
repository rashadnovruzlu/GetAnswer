using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class CityService : EntityService<City>, ICityService
    {
        IUnitOfWork _unitOfWork;
        ICityRepository _cityRepository;

        public CityService(IUnitOfWork unitOfWork, ICityRepository cityRepository)
            : base(unitOfWork, cityRepository)
        {
            _unitOfWork = unitOfWork;
            _cityRepository = cityRepository;
        }
 
        public City GetById(int Id)
        {
            return _cityRepository.GetById(Id);
        }

        
    }
}
