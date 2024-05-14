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
    public class ColaboradorBusiness: IColaboradorBusiness
    {
        private readonly IColaboradorRepository _colaboradorRepository;

        public ColaboradorBusiness(IColaboradorRepository colaboradorRepository)
        {
            _colaboradorRepository = colaboradorRepository;
        }

        public async Task<List<Colaborador>> ObterColaboradores()
        {
            var retorno = await _colaboradorRepository.ConsultarColaboradores();

            return retorno;
        }
    }
}
