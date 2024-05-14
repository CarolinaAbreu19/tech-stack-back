using System.Collections.Generic;
using System.Threading.Tasks;
using TechStackBack.DTO;
using TechStackProcesso.Models;

namespace TechStackBack.IRepositories
{
    public interface IColaboradorRepository
    {
        Task<List<Colaborador>> ConsultarColaboradores();
    }
}
