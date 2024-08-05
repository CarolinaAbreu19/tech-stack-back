using System.Collections.Generic;

namespace TechStackProcesso.Models
{
    public class NivelConhecimento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Valor { get; set; }

        public ICollection<Resposta> Respostas { get; set; }
    }
}
