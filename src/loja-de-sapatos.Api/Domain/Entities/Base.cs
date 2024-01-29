﻿using System.ComponentModel.DataAnnotations;

namespace loja_de_sapatos.Api.Domain.Entities
{
    public abstract class Base
    {
        public int Id { get; set; } 
        public DateTime DateCreate { get; set; } = DateTime.Now;

    }
}
