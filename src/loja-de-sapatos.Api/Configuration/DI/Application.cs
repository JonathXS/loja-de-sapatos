using loja_de_sapatos.Api.Domain.Interfaces.Services;
using loja_de_sapatos.Api.Services;

namespace loja_de_sapatos.Api.Configuration.DI
{
    public static class Application
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<ISaleService, SaleService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<ISellerService, SellerService>();
            services.AddScoped<IClientService, ClientService>();
            return services;
        }  
    }
}
