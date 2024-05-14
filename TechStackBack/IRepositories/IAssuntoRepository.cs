using System.Collections.Generic;
using System.Threading.Tasks;
using TechStackBack.DTO;
using TechStackProcesso.Models;

namespace TechStackBack.IRepositories
{
    public interface IAssuntoRepository
    {
        Task<List<Assunto>> ConsultarAssuntosPorId(List<int> idsAssunto);
    }
}
