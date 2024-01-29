namespace loja_de_sapatos.Api.Domain.Entities
{
    public class Client : Base
    {
        public string Name { get; set; }
        public Address? Address { get; set; }
    }
}
