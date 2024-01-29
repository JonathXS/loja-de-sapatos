using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.Entities;

namespace loja_de_sapatos.Api.Domain.Interfaces.Repositories
{
    public interface IProductRepository
    {
        Task UpdateProduct(UpdateProductDTO updateProduct, CancellationToken cancellationToken);
        Task DeleteProduct(int id, CancellationToken cancellationToken);
        Task<List<Product?>> GetProducts(CancellationToken cancellationToken);
        Task<Product?> GetProduct(int id, CancellationToken cancellationToken);
        Task InsertProduct(Product product, CancellationToken cancellationToken);
    }
}
