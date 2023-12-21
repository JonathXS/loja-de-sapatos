using loja_de_sapatos.Api.Domain.Interfaces.Services;
using loja_de_sapatos.Api.Services;

namespace loja_de_sapatos.Api.Configuration.DI
{
    public static class Application
    {
        public static IServiceCollection AdicionarApplication(this IServiceCollection services)
        {
            services.AddScoped<IVendedorService, VendedorService>();
            return services;
        }  
    }
}
