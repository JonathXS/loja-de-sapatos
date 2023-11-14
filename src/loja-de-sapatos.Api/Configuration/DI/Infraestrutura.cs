using loja_de_sapatos.Api.Domain.Context;
using Microsoft.EntityFrameworkCore;

namespace loja_de_sapatos.Api.Configuration.DI
{
    public static class Infraestrutura
    {
        public static IServiceCollection AdicionarInfraestrutura(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseMySQL(configuration.GetConnectionString("DefaultConnection"));
            });

            services.AddRepositories();

            return services;
        }

        public static IServiceCollection AddRepositories(this IServiceCollection services) 
        {
            return services;
        }
    }
}
