using loja_de_sapatos.Api.Domain.Context;
using loja_de_sapatos.Api.Domain.Interfaces.Repositories;
using loja_de_sapatos.Api.Domain.Interfaces.Services;
using loja_de_sapatos.Api.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace loja_de_sapatos.Api.Configuration.DI
{
    public static class Infraestrutura
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            var a = configuration.GetValue<string>("ConnectionStrings:DefaultConnection");
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseMySql(a, ServerVersion.AutoDetect(a));
            });

            services.AddRepositories();

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services) 
        {
            services.AddScoped<ISaleRepository, SaleRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<ISellerRepository, SellerRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            return services;
        }
    }
}
