using System;
using System.Collections.Generic;

namespace TechStackProcesso.Models
{
    public class Preenchimento
    {
        public int Id { get; set; }
        public int IdColaborador { get; set; }
        public int IdTechStack { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime? DataFinalizacao { get; set; }
        
        public Colaborador Colaborador { get; set; }
        public TechStack TechStack { get; set; }

        public ICollection<Resposta> Respostas { get; set; }
    }
}
