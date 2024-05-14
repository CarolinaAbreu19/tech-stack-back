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
    public class TechStackBusiness: ITechStackBusiness
    {
        private readonly ITechStackRepository _techStackRepository;

        public TechStackBusiness(ITechStackRepository techStackRepository)
        {
            _techStackRepository = techStackRepository;
        }

        public async Task<List<TechStack>> ObterTechStacks()
        {
            var retorno = await _techStackRepository.ConsultarTechStacks();

            return retorno;
        }
    }
}
