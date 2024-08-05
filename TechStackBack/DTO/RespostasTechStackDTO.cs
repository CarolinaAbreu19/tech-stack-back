using System;

namespace TechStackBack.DTO
{
    public class RespostasTechStackDTO
    {
        public int Quantidade { get; set; }
        public int Desconhecido { get; set; }
        public int Teorico { get; set; }
        public int Basico { get; set; }
        public int Intermediario { get; set; }
        public int Avancado { get; set; }
        public int Especialista { get; set; }
        public string DataUltimaResposta { get; set; }

    }
}
