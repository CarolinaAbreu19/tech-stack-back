using System.Collections.Generic;

namespace TechStackProcesso.Models
{
    public class TipoConhecimento
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public ICollection<AreaConhecimento> AreasConhecimento { get; set; }
    }
}
