using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStackBack.IRepositories;
using TechStackProcesso.Data;
using TechStackProcesso.Models;

namespace TechStackBack.Repositories
{
    public class AssuntoRepository: IAssuntoRepository
    {
        private readonly AppDbContext _context;
        public AssuntoRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<List<Assunto>> ConsultarAssuntosPorIdAreaConhecimento(int idAreaConhecimento)
        {
            var query = _context.Set<Assunto>().AsSplitQuery()
                .Include(a => a.Relevancia).AsSplitQuery()
                .Where(e => e.IdAreaConhecimento.Equals(idAreaConhecimento));

            return query.ToListAsync();
        }
    }
}
