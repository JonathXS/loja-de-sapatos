using loja_de_sapatos.Api.Domain.Entities;

namespace loja_de_sapatos.Api.Domain.DTO.Request
{
    public class CreateVendedorDTO
    {
        public string Nome { get; set; }
        public CreateEnderecoDTO Endereco { get; set; }
    }
}
