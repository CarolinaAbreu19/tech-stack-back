using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStackBack.IRepositories;
using TechStackProcesso.Data;
using TechStackProcesso.Models;

namespace TechStackBack.Repositories
{
    public class RespostaRepository: IRespostaRepository
    {
        private readonly AppDbContext _context;
        public RespostaRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<List<Resposta>> ConsultarRespostasColaborador(int idColaborador)
        {
            var query = _context.Set<Resposta>()
                .Where(e => e.IdColaborador == idColaborador);

            return query.ToListAsync();
        }
    }
}
