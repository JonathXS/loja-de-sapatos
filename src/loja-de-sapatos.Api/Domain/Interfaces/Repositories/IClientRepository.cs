using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.Entities;
using System.Threading.Tasks;

namespace loja_de_sapatos.Api.Domain.Interfaces.Repositories
{
    public interface IClientRepository
    {
        Task UpdateClient(UpdateClientDTO updateClient, CancellationToken cancellationToken);
        Task DeleteClient(int id, CancellationToken cancellationToken);
        Task<List<Client?>> GetClients(CancellationToken cancellationToken);
        Task<Client?> GetClient(int id, CancellationToken cancellationToken);
        Task InsertClient(Client client, CancellationToken cancellationToken);
    }
}
