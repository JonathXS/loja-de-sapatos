namespace loja_de_sapatos.Api.Domain.DTO.Request
{
    public class CreateClientDTO
    {
        public string Name { get; set; }
        public CreateAddressDTO Address{ get; set; }
    }
}
