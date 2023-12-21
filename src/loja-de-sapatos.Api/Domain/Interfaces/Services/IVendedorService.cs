using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.Entities;

namespace loja_de_sapatos.Api.Domain.Interfaces.Services
{
    public interface IVendedorService
    {
        Task<Vendedor?> GetVendedor(int id);
        Task InsertVendedor(CreateVendedorDTO request);
    }
}
