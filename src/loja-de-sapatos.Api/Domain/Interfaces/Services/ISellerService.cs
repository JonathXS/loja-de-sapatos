using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.DTO.Response;
using loja_de_sapatos.Api.Domain.Entities;

namespace loja_de_sapatos.Api.Domain.Interfaces.Services
{
    public interface ISellerService
    {
        Task UpdateSeller(UpdateSellerDTO updateSeller, CancellationToken cancellationToken);
        Task DeleteSeller(int id, CancellationToken cancellationToken);
        Task<List<SellerResponse?>> GetSellers(CancellationToken cancellationToken);
        Task<SellerResponse?> GetSeller(int id, CancellationToken cancellationToken);
        Task InsertSeller(CreateSellerDTO request, CancellationToken cancellationToken);
    }
}
