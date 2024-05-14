using System.Collections.Generic;
using System.Threading.Tasks;
using TechStackBack.DTO;
using TechStackProcesso.Models;

namespace TechStackBack.IRepositories
{
    public interface IRespostaRepository
    {
        Task<List<Resposta>> ConsultarRespostasColaborador(int idColaborador);
    }
}
