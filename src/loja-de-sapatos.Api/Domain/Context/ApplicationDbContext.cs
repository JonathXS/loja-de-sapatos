using loja_de_sapatos.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace loja_de_sapatos.Api.Domain.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Client> Client { get; set; }
        public DbSet<Address> Address { get; set;}
        public DbSet<Product> Product { get; set;}
        public DbSet<Sale> Sale { get; set;}
        public DbSet<Seller> Seller { get; set;}

        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
