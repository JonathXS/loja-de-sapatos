namespace loja_de_sapatos.Api.Domain.DTO.Request
{
    public class CreateEnderecoDTO
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
    }
}
