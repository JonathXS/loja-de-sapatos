using loja_de_sapatos.Api.Domain.DTO.Request;
using loja_de_sapatos.Api.Domain.Entities;
using loja_de_sapatos.Api.Domain.Interfaces.Repositories;
using loja_de_sapatos.Api.Domain.Interfaces.Services;

namespace loja_de_sapatos.Api.Services
{
    public class VendedorService : IVendedorService
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
            var vendedor = new Vendedor
            {
                Nome = request.Nome,
                Endereco = new Endereco(request.Endereco.Rua, request.Endereco.Numero, request.Endereco.Bairro, request.Endereco.Cidade, request.Endereco.Estado)
            };
            await _vendedorRepository.InsertVendedor(vendedor);

        }

    }
}
