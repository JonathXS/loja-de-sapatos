namespace loja_de_sapatos.Api.Domain.Entities
{
    public class Sale : Base
    {
        public Seller? Seller { get; set; }
        public Client? Client { get; set; }
        public Product? Product { get; set; }
    }
}
