using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStackBack.DTO;
using TechStackBack.Filters;
using TechStackBack.Interfaces;
using TechStackBack.IRepositories;
using TechStackProcesso.Data;
using TechStackProcesso.Models;

namespace TechStackBack.Business
{
    public class AssuntoBusiness: IAssuntoBusiness
    {
        private readonly IAssuntoRepository _assuntoRepository;

        public AssuntoBusiness(IAssuntoRepository assuntoRepository)
        {
            _assuntoRepository = assuntoRepository;
        }

        public async Task<List<AssuntoDTO>> ObterAssuntosPorAreaConhecimento(int idAreaConhecimento)
        {
            var assuntos = await _assuntoRepository.ConsultarAssuntosPorIdAreaConhecimento(idAreaConhecimento);
            var retorno = new List<AssuntoDTO>();

            foreach (var assunto in assuntos)
            {
                var novoAssunto = new AssuntoDTO()
                {
                    Id = assunto.Id,
                    Nome = assunto.Descricao,
                    Relevancia = assunto.Relevancia.Descricao,
                };

                retorno.Add(novoAssunto);
            }

            return retorno;
        }
    }
}
