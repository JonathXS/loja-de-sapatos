using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.DTO.Response;

namespace loja_de_sapatos.Api.Domain.Interfaces.Services
{
    public interface IProductService
    {
        Task UpdateProduct(UpdateProductDTO updateProduct, CancellationToken cancellationToken);
        Task DeleteProduct(int id, CancellationToken cancellationToken);
        Task<List<ProductResponse?>> GetProducts(CancellationToken cancellationToken);
        Task<ProductResponse?> GetProduct(int id, CancellationToken cancellationToken);
        Task InsertProduct(CreateProductDTO request, CancellationToken cancellationToken);
    }
}
