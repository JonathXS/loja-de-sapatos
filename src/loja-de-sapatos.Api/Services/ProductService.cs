using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.DTO.Response;
using loja_de_sapatos.Api.Domain.Entities;
using loja_de_sapatos.Api.Domain.Interfaces.Repositories;
using loja_de_sapatos.Api.Domain.Interfaces.Services;
using loja_de_sapatos.Api.Domain.Repositories;
using Mapster;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Globalization;

namespace loja_de_sapatos.Api.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService (IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task UpdateProduct (UpdateProductDTO updateProduct, CancellationToken cancellationToken)
        {
            await _productRepository.UpdateProduct(updateProduct, cancellationToken);
        }

        public async Task DeleteProduct(int id, CancellationToken cancellationToken)
        {
            await _productRepository.DeleteProduct(id, cancellationToken);
        }

        public async Task<List<ProductResponse?>> GetProducts(CancellationToken cancellationToken)
        {
            var products = await _productRepository.GetProducts(cancellationToken);
            
            return products.Adapt<List<ProductResponse?>>();
        }

        public async Task<ProductResponse?> GetProduct(int id, CancellationToken cancellationToken)
        {
            var product = await _productRepository.GetProduct(id, cancellationToken);

            return product.Adapt<ProductResponse?>();
        }

        public async Task InsertProduct (CreateProductDTO request, CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Name = request.Name,
                Price = request.Price,
                DateCreate = DateTime.Now
            };
            
            await _productRepository.InsertProduct(product, cancellationToken);
        }
    }
}
