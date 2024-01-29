using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.DTO.Response;
using loja_de_sapatos.Api.Domain.Entities;

namespace loja_de_sapatos.Api.Domain.Interfaces.Services
{
    public interface IClientService
    {
        Task UpdateClient(UpdateClientDTO updateClient, CancellationToken cancellationToken);
        Task DeleteClient(int id, CancellationToken cancellationToken);
        Task<List<ClientResponse>> GetClients(CancellationToken cancellationToken);
        Task<ClientResponse?> GetClient(int id, CancellationToken cancellationToken);
        Task InsertClient(CreateClientDTO request, CancellationToken cancellationToken);
    }
}
