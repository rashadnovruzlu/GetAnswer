using System.Collections.Generic;
using System.Linq;
using GetAnswer.Repository;
using GetAnswer.Service.EntityService;
using GetAnswer.Model;

namespace GetAnswer.Service
{
    public class ClientService : EntityService<Client>, IClientService
    {
        IUnitOfWork _unitOfWork;
        IClientRepository _clientRepository;

        public ClientService(IUnitOfWork unitOfWork, IClientRepository clientRepository)
            : base(unitOfWork, clientRepository)
        {
            _unitOfWork = unitOfWork;
            _clientRepository = clientRepository;
        }
 
        public Client GetById(string Id)
        {
            return _clientRepository.GetById(Id);
        }

        
    }
}
