using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStackBack.DTO;
using TechStackBack.Enums;
using TechStackBack.Filters;
using TechStackBack.Interfaces;
using TechStackBack.IRepositories;
using TechStackBack.Util;
using TechStackProcesso.Data;
using TechStackProcesso.Models;

namespace TechStackBack.Business
{
    public class TechStackBusiness: ITechStackBusiness
    {
        private readonly ITechStackRepository _techStackRepository;

        public TechStackBusiness(ITechStackRepository techStackRepository)
        {
            _techStackRepository = techStackRepository;
        }

        public async Task<List<GestaoTechStackDTO>> ObterTechStacks()
        {
            var techStacks = await _techStackRepository.ConsultarTechStacks();
            var retorno = new List<GestaoTechStackDTO>();
            foreach (var techstack in techStacks)
            {
                var novaTechStack = new GestaoTechStackDTO()
                {
                    Id = techstack.Id,
                    Nome = techstack.Nome,
                    QuantidadePreenchimentos = techstack.Preenchimentos.Count(),
                };

                retorno.Add(novaTechStack);
            }

            return retorno;
        }
        
        public async Task<InformacoesTechStackDTO> ObterDetalhesTechStack(int idTechStack)
        {
            var techStack = await _techStackRepository.ConsultarTechStackPorId(idTechStack);

            var retorno = new InformacoesTechStackDTO()
            {
                Id = idTechStack,
                Nome = techStack.Nome,
                Area = techStack.Area,
                Detalhes = techStack.Descricao,
                DataCriacao = ManipularData.ConverterToStringSemHora(techStack.DataCriacao),
                Respostas = MontarRespostas(techStack),
                AreasConhecimento = MontarAreasConhecimento(techStack)
            };
            
            return retorno;
        }

        private RespostasTechStackDTO MontarRespostas(TechStack techStack)
        {
            var respostas = techStack.Preenchimentos.SelectMany(p => p.Respostas).ToList();
            
            if(respostas.Count != 0)
            {
                return new RespostasTechStackDTO()
                {
                    Quantidade = respostas.Count(),
                    Desconhecido = respostas.Where(r => r.Assunto.IdRelevancia == (int)RelevanciaEnum.Desconhecido).Count(),
                    Teorico = respostas.Where(r => r.Assunto.IdRelevancia == (int)RelevanciaEnum.Teorico).Count(),
                    Basico = respostas.Where(r => r.Assunto.IdRelevancia == (int)RelevanciaEnum.Basico).Count(),
                    Intermediario = respostas.Where(r => r.Assunto.IdRelevancia == (int)RelevanciaEnum.Intermediario).Count(),
                    Avancado = respostas.Where(r => r.Assunto.IdRelevancia == (int)RelevanciaEnum.Avancado).Count(),
                    Especialista = respostas.Where(r => r.Assunto.IdRelevancia == (int)RelevanciaEnum.Especialista).Count(),
                    DataUltimaResposta = respostas.OrderByDescending(r => r.DataUltimaAlteracao).FirstOrDefault().ToString(),
                };
            }

            return new RespostasTechStackDTO();
        }

        private List<AreaConhecimentoDTO> MontarAreasConhecimento(TechStack techStack)
        {
            var areasConhecimento = techStack.AreasConhecimento.ToList();
            var retorno = new List<AreaConhecimentoDTO>();

            if (areasConhecimento != null) {
                foreach (var area in areasConhecimento)
                {
                    var novaArea = new AreaConhecimentoDTO()
                    {
                        Id = area.Id,
                        IdTipoConhecimento = area.IdTipoConhecimento,
                        Nome = area.Descricao,
                        QuantidadeAssuntos = area.Assuntos.Count(),
                    };

                    retorno.Add(novaArea);
                }

                return retorno;
            }
            return new List<AreaConhecimentoDTO>();
        }
    }
}
