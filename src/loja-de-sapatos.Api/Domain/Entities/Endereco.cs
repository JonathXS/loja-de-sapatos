﻿namespace loja_de_sapatos.Api.Domain.Entities
{
    public class Endereco : Base
    {
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Endereco(int id, string rua, int numero, string bairro, string cidade, string estado)
        {
            Id = id;
            Rua = rua;
            Numero = numero;
            Bairro = bairro;
            Cidade = cidade;
            Estado = estado;
        }
    }
}