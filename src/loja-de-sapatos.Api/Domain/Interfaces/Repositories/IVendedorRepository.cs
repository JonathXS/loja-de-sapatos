using loja_de_sapatos.Api.Domain.Entities;

namespace loja_de_sapatos.Api.Domain.Interfaces.Repositories
{
    public interface IVendedorRepository
    {
        Task<Vendedor?> GetVendedor(int id);
        Task InsertVendedor(Vendedor vendedor);
    }
}
