using System.Collections.Generic;

namespace TechStackProcesso.Models
{
    public class Relevancia
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public ICollection<Assunto> Assuntos { get; set; }
    }
}
