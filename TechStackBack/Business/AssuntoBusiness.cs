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

        public async Task<List<Assunto>> ObterAssuntos(AssuntoFilterDTO filter)
        {
            var retorno = await _assuntoRepository.ConsultarAssuntosPorId(filter.IdsAssunto);

            return retorno;
        }
    }
}
