using System;

namespace TechStackProcesso.Models
{
    public class Resposta
    {
        public int Id { get; set; }
        public int IdColaborador { get; set; }
        public int IdAssunto { get; set; }
        public int IdPreenchimento { get; set; }
        public int IdNivelConhecimento { get; set; }
        public DateTime DataUltimaAlteracao { get; set; }

        public Assunto Assunto { get; set; }
        public Preenchimento Preenchimento { get; set; }
        public NivelConhecimento NivelConhecimento { get; set; }
    }
}
