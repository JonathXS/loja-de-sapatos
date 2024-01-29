namespace loja_de_sapatos.Api.Domain.DTO.Response
{
    public class SellerResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DateCreate { get; set; }
        public AddressResponse? Address { get; set; }
    }
}
