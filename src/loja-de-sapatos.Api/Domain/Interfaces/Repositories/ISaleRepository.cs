using loja_de_sapatos.Api.Domain.Entities;

namespace loja_de_sapatos.Api.Domain.Interfaces.Repositories
{
    public interface ISaleRepository
    {
        Task DeleteSale(int id, CancellationToken cancellationToken);
        Task<List<Sale>> GetSales(CancellationToken cancellationToken);
        Task<Sale?> GetSale(int id, CancellationToken cancellationToken);
        Task InsertSale(Sale sale, CancellationToken cancellationToken);
    }
}
