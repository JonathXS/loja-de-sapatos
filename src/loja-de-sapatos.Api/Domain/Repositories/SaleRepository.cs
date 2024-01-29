using loja_de_sapatos.Api.Domain.Context;
using loja_de_sapatos.Api.Domain.Entities;
using loja_de_sapatos.Api.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace loja_de_sapatos.Api.Domain.Repositories
{
    public class SaleRepository : ISaleRepository
    {
        private readonly ApplicationDbContext _context;
        public SaleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task DeleteSale (int id, CancellationToken cancellationToken)
        {
            var sale = await _context.Sale.FirstOrDefaultAsync (x => x.Id == id);
            if (sale == null) return;

             _context.Remove(sale);
            await _context.SaveChangesAsync(cancellationToken);

        }

        public async Task<List<Sale>> GetSales(CancellationToken cancellationToken)
        {
            return await _context.Sale.Include(x => x.Product).Include(x => x.Seller).Include(x => x.Client).ToListAsync(cancellationToken);
        }

        public async Task<Sale?> GetSale(int id, CancellationToken cancellationToken)
        {
            return await _context.Sale.Include(x => x.Product).Include(x => x.Seller).Include(x => x.Client).FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
        }

        public async Task InsertSale (Sale sale, CancellationToken cancellationToken)
        {
            _context.Add(sale);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
