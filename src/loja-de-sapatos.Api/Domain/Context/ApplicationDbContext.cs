using loja_de_sapatos.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace loja_de_sapatos.Api.Domain.Context
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set;}
        public DbSet<Produto> Produtos { get; set;}
        public DbSet<Venda> Vendas { get; set;}
        public DbSet<Vendedor> Vendedores { get; set;}

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
