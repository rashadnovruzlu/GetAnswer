using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class ClientsService : EntityService<Clients>, IClientsService
    {
        IUnitOfWork _unitOfWork;
        IClientsRepository _clientsRepository;

        public ClientsService(IUnitOfWork unitOfWork, IClientsRepository clientsRepository)
            : base(unitOfWork, clientsRepository)
        {
            _unitOfWork = unitOfWork;
            _clientsRepository = clientsRepository;
        }
 
        public Clients GetById(string Id)
        {
            return _clientsRepository.GetById(Id);
        }

        
    }
}
