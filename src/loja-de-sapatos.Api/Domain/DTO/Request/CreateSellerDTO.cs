using loja_de_sapatos.Api.Domain.Entities;

namespace loja_de_sapatos.Api.Domain.DTO.Request
{
    public class CreateSellerDTO
    {
        public string Name { get; set; }
        public CreateAddressDTO Address { get; set; }
    }
}
