namespace loja_de_sapatos.Api.Domain.DTO.Request
{
    public class CreateAddressDTO
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
