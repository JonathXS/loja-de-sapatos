using loja_de_sapatos.Api.Domain.Context;
using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.Entities;
using loja_de_sapatos.Api.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
namespace loja_de_sapatos.Api.Domain.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task UpdateProduct(UpdateProductDTO updateProduct, CancellationToken cancellationToken)
        {
            var product = await _context.Product.FirstOrDefaultAsync(x => x.Id == updateProduct.Id);
            if (product == null) return;

            product.Name = updateProduct.Name;
            product.Price = updateProduct.Price;

            _context.Product.Update(product);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteProduct (int id, CancellationToken cancellationToken)
        {
            var product = await _context.Product.FirstOrDefaultAsync(x => x.Id == id);
            if (product == null) return;

            _context.Product.Remove(product);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<Product?>> GetProducts (CancellationToken cancellationToken)
        {
            return await _context.Product.ToListAsync(cancellationToken);
        }

        public async Task<Product?> GetProduct(int id, CancellationToken cancellationToken)
        {
            return await _context.Product.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task InsertProduct(Product product, CancellationToken cancellationToken)
        {
            _context.Add(product);
            await _context.SaveChangesAsync(cancellationToken);
        }

    }
}
