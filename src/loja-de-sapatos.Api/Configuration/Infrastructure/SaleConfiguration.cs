using loja_de_sapatos.Api.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace loja_de_sapatos.Api.Configuration.Infrastructure
{
    internal class SaleConfiguration : IEntityTypeConfiguration<Sale>
    {
        public void Configure(EntityTypeBuilder<Sale> builder)
        {
            builder.HasOne(x => x.Client);
            builder.HasOne(x => x.Product);
            builder.HasOne(x => x.Seller);
        }
    }
}
