namespace loja_de_sapatos.Api.Domain.Entities
{
    public class Produto : Base
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        public Produto(int id, string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
