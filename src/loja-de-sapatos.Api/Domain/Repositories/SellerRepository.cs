using loja_de_sapatos.Api.Domain.Context;
using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.Entities;
using loja_de_sapatos.Api.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace loja_de_sapatos.Api.Domain.Repositories
{
    public class SellerRepository : ISellerRepository
    {
        private readonly ApplicationDbContext _context;

        public SellerRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task DeleteSeller(int id, CancellationToken cancellationToken)
        {

            var seller = await _context.Seller.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (seller == null) return;

            _context.Seller.Remove(seller);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task UpdateSeller(UpdateSellerDTO updateSeller, CancellationToken cancellationToken)
        {
            var seller = await _context.Seller.FirstOrDefaultAsync(x => x.Id == updateSeller.Id, cancellationToken);
            if (seller == null) return;

            seller.Name = updateSeller.Name;
            
            _context.Seller.Update(seller);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<Seller?>> GetSellers(CancellationToken cancellationToken)
        {
            return await _context.Seller.Include(x => x.Address).ToListAsync(cancellationToken);
        }

        public async Task<Seller?> GetSeller(int id, CancellationToken cancellationToken)
        {
            return await _context.Seller.Include(x => x.Address).FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

        }

        public async Task InsertSeller(Seller seller, CancellationToken cancellationToken)
        {
            _context.Seller.Add(seller);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
