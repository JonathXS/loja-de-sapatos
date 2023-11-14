namespace loja_de_sapatos.Api.Domain.Entities
{
    public class Venda : Base
    {
        public Vendedor Vendedor { get; set; }
        public Cliente Cliente { get; set; }
        public Produto Produto { get; set; }

    }
}
