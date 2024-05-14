using System;

namespace TechStackProcesso.Models
{
    public class TechStack
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
    }
}
