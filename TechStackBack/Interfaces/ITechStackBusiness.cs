using System.Collections.Generic;
using System.Threading.Tasks;
using TechStackBack.DTO;
using TechStackBack.Filters;
using TechStackProcesso.Models;

namespace TechStackBack.Interfaces
{
    public interface ITechStackBusiness
    {
        Task<List<TechStack>> ObterTechStacks();
    }
}
