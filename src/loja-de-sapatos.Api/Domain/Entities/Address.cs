namespace loja_de_sapatos.Api.Domain.Entities
{
    public class Address : Base
    {
        public string Street { get; set; }
        public int Number { get; set; }
        public string District { get; set; }
        public string City { get; set; }
        public string State { get; set; }

        public Address(string street, int number, string district, string city, string state)
        {
            Street = street;
            Number = number;
            District = district;
            City = city;
            State = state;
        }
    }
}
