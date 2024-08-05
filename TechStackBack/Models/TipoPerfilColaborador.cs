using System.Collections.Generic;

namespace TechStackProcesso.Models
{
    public class TipoPerfilColaborador
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public ICollection<Colaborador> Colaboradores { get; set; }
    }
}
