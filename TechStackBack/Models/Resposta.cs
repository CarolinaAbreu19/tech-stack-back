using System;

namespace TechStackProcesso.Models
{
    public class Resposta
    {
        public int Id { get; set; }
        public int IdColaborador { get; set; }
        public int IdAssunto { get; set; }
        public int IdNivelConhecimento { get; set; }
        public DateTime DataPreenchimento { get; set; }
    }
}
