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

        public Task<List<Assunto>> ConsultarAssuntosPorId(List<int> idsAssunto)
        {
            var query = _context.Set<Assunto>()
                .Where(e => idsAssunto.Contains(e.Id));

            return query.ToListAsync();
        }
    }
}
