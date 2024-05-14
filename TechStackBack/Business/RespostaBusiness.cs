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
    public class RespostaBusiness: IRespostaBusiness
    {
        private readonly IRespostaRepository _respostaRepository;

        public RespostaBusiness(IRespostaRepository respostaRepository)
        {
            _respostaRepository = respostaRepository;
        }

        public async Task<List<Resposta>> ObterRespostasColaborador(int idColaborador)
        {
            var retorno = await _respostaRepository.ConsultarRespostasColaborador(idColaborador);

            return retorno;
        }
    }
}
