using System.Collections.Generic;
using System.Threading.Tasks;
using TechStackBack.DTO;
using TechStackProcesso.Models;

namespace TechStackBack.IRepositories
{
    public interface IAreaConhecimentoRepository
    {
        Task<AreaConhecimento> ObterPorId(int idArea);
    }
}
