using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class FiletypeService : EntityService<FileType>, IFiletypeService
    {
        IUnitOfWork _unitOfWork;
        IFiletypeRepository _filetypeRepository;

        public FiletypeService(IUnitOfWork unitOfWork, IFiletypeRepository filetypeRepository)
            : base(unitOfWork, filetypeRepository)
        {
            _unitOfWork = unitOfWork;
            _filetypeRepository = filetypeRepository;
        }
 
        public FileType GetById(string Id)
        {
            return _filetypeRepository.GetById(Id);
        }

        
    }
}
