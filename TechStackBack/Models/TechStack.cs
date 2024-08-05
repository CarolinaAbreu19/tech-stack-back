using System;
using System.Collections.Generic;

namespace TechStackProcesso.Models
{
    public class TechStack
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Area { get; set; }
        public DateTime DataCriacao { get; set; }

        public ICollection<AreaConhecimento> AreasConhecimento { get; set; }
        public ICollection<Preenchimento> Preenchimentos { get; set; }
    }
}
