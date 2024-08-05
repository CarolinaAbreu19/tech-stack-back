using System.Collections.Generic;

namespace TechStackProcesso.Models
{
    public class Colaborador
    {
        public int Id { get; set; }
        public int IdPerfilColaborador { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }

        public TipoPerfilColaborador TipoPerfilColaborador { get; set; }

        public ICollection<Preenchimento> Preenchimentos { get; set; }
    }
}
