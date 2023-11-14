using loja_de_sapatos.Api.Domain.Context;
using loja_de_sapatos.Api.Domain.Entities;
using loja_de_sapatos.Api.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace loja_de_sapatos.Api.Domain.Repositories
{
    public class VendedorRepository : IVendedorRepository
    {
        private readonly ApplicationDbContext _context;

        public VendedorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Vendedor?> GetVendedor(int id)
        {
            return await _context.Vendedores.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task InsertVendedor(Vendedor vendedor)
        {
            _context.Vendedores.Add(vendedor);
            await _context.SaveChangesAsync();
        }
    }
}
