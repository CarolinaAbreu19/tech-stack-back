using System.Collections.Generic;
using System.Threading.Tasks;
using TechStackBack.DTO;
using TechStackBack.Filters;
using TechStackProcesso.Models;

namespace TechStackBack.Interfaces
{
    public interface IAssuntoBusiness
    {
        Task<List<Assunto>> ObterAssuntos(AssuntoFilterDTO filter);
    }
}
