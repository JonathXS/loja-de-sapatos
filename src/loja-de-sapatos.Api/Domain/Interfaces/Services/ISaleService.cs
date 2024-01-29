using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.DTO.Response;
using loja_de_sapatos.Api.Domain.Entities;

namespace loja_de_sapatos.Api.Domain.Interfaces.Services
{
    public interface ISaleService
    {
        Task DeleteSale(int id, CancellationToken cancellationToken);
        Task<List<SaleResponse>> GetSales(CancellationToken cancellationToken);
        Task<SaleResponse?> GetSale(int id, CancellationToken cancellationToken);
        Task<bool> InsetSale(CreateSaleDTO request, CancellationToken cancellationToken);
    }
}
