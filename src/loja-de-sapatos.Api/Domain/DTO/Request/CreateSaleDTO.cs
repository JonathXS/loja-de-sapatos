using loja_de_sapatos.Api.Domain.Entities;

namespace loja_de_sapatos.Api.Domain.DTO.Request
{
    public class CreateSaleDTO
    {
        public int ClientId { get; set; }
        public int SellerId { get; set; }
        public int ProdID { get; set; }

    }
}
