using System.Collections.Generic;

namespace TechStackProcesso.Models
{
    public class Assunto
    {
        public int Id { get; set; }
        public int IdRelevancia { get; set; }
        public int IdAreaConhecimento { get; set; }
        public string Descricao { get; set; }

        public AreaConhecimento AreaConhecimento { get; set; }
        public Relevancia Relevancia { get; set; }

        public ICollection<Resposta> Respostas { get; set; }
    }
}
