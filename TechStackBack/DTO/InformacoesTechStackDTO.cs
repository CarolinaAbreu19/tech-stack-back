using System;
using System.Collections.Generic;
using TechStackProcesso.Models;

namespace TechStackBack.DTO
{
    public class InformacoesTechStackDTO
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Area { get; set; }
        public string Detalhes { get; set; }
        public string Responsaveis { get; set; }
        public string DataCriacao { get; set; }
        public RespostasTechStackDTO Respostas { get; set; }
        public List<AreaConhecimentoDTO> AreasConhecimento { get; set; }

    }
}
