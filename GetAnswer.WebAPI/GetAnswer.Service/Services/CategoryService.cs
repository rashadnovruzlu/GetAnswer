using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class CategoryService : EntityService<Category>, ICategoryService
    {
        IUnitOfWork _unitOfWork;
        ICategoryRepository _categoryRepository;

        public CategoryService(IUnitOfWork unitOfWork, ICategoryRepository categoryRepository)
            : base(unitOfWork, categoryRepository)
        {
            _unitOfWork = unitOfWork;
            _categoryRepository = categoryRepository;
        }
 
        public Category GetById(int Id)
        {
            return _categoryRepository.GetById(Id);
        }

        
    }
}
