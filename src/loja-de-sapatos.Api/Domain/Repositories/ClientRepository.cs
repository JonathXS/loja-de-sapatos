using loja_de_sapatos.Api.Domain.Context;
using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.Entities;
using loja_de_sapatos.Api.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace loja_de_sapatos.Api.Domain.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly ApplicationDbContext _context;

        public ClientRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task UpdateClient(UpdateClientDTO updateClient, CancellationToken cancellationToken)
        {
            var client = await _context.Client.FirstOrDefaultAsync(x => x.Id == updateClient.Id, cancellationToken);
            if (client == null) return;

            client.Name = updateClient.Name;

            _context.Client.Update(client);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteClient(int id, CancellationToken cancellationToken)
        {
            var client = await _context.Client.FirstOrDefaultAsync(x => x.Id == id, cancellationToken);
            if (client == null) return;

            _context.Client.Remove(client);
            await _context.SaveChangesAsync(cancellationToken);
        }

        public async Task<List<Client?>> GetClients(CancellationToken cancellationToken)
        {
            return await _context.Client.Include(x => x.Address).ToListAsync(cancellationToken);
        }

        public async Task<Client?> GetClient(int id, CancellationToken cancellationToken)
        {

            return await _context.Client.Include(x => x.Address).FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

        }

        public async Task InsertClient(Client client, CancellationToken cancellationToken)
        {
            _context.Add(client);
            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
