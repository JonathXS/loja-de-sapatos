using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.Entities;
using System.Threading;

namespace loja_de_sapatos.Api.Domain.Interfaces.Repositories
{
    public interface ISellerRepository
    {
        Task UpdateSeller(UpdateSellerDTO updateSeller, CancellationToken cancellationToken);
        Task DeleteSeller(int id, CancellationToken cancellationToken);
        Task<List<Seller?>> GetSellers(CancellationToken cancellationToken);
        Task<Seller?> GetSeller(int id, CancellationToken cancellationToke);
        Task InsertSeller(Seller seller, CancellationToken cancellationToken);
    }
}
