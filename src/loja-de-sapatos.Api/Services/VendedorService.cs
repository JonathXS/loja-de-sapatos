using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.Entities;
using loja_de_sapatos.Api.Domain.Interfaces.Repositories;

namespace loja_de_sapatos.Api.Services
{
    public class VendedorService
    {
        private readonly IVendedorRepository _vendedorRepository;

        public VendedorService(IVendedorRepository vendedorRepository)
        {
            _vendedorRepository = vendedorRepository;
        }

        public async Task<Vendedor?> GetVendedor(int id)
        {
            return await _vendedorRepository.GetVendedor(id);
        }

        public async Task InsertVendedor(CreateVendedorDTO request)
        {
            await _vendedorRepository.InsertVendedor(new Vendedor());
        }
    }
}
