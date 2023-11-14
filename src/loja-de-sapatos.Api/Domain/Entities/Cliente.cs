namespace loja_de_sapatos.Api.Domain.Entities
{
    public class Cliente : Base
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }
    }
}
