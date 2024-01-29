using System.Globalization;

namespace loja_de_sapatos.Api.Domain.Entities
{
    public class Product : Base
    {
        public string Name { get; set; }
        public double Price { get; set; } 
    }
}
