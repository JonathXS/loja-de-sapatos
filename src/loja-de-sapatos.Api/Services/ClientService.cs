using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.DTO.Response;
using loja_de_sapatos.Api.Domain.Entities;
using loja_de_sapatos.Api.Domain.Interfaces.Repositories;
using loja_de_sapatos.Api.Domain.Interfaces.Services;
using Mapster;

namespace loja_de_sapatos.Api.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task UpdateClient(UpdateClientDTO updateClient, CancellationToken cancellationToken)
        {
            await _clientRepository.UpdateClient(updateClient, cancellationToken);
        }

        public async Task DeleteClient(int id, CancellationToken cancellationToken)
        {
            await _clientRepository.DeleteClient(id, cancellationToken);
        }

        public async Task<List<ClientResponse?>> GetClients(CancellationToken cancellationToken)
        {
            var clients = await _clientRepository.GetClients(cancellationToken);
            
            return clients.Adapt<List<ClientResponse?>>();
        }



        public async Task<ClientResponse?> GetClient(int id, CancellationToken cancellationToken)
        {
            var client = await _clientRepository.GetClient(id, cancellationToken);
            
             client.Adapt<ClientResponse>();
            
            return client.Adapt<ClientResponse>();
        }

        public async Task InsertClient(CreateClientDTO request, CancellationToken cancellationToke)
        {
            var client = new Client
            {
                Name = request.Name,
                Address = new Address(request.Address.Street, request.Address.Number, request.Address.District, request.Address.City, request.Address.State),
                DateCreate = DateTime.Now
            };
            await _clientRepository.InsertClient(client, cancellationToke);
        }

    }
}

