using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStackBack.IRepositories;
using TechStackProcesso.Data;
using TechStackProcesso.Models;

namespace TechStackBack.Repositories
{
    public class RelevanciaRepository: IRelevanciaRepository
    {
        private readonly AppDbContext _context;
        public RelevanciaRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<Relevancia> ObterPorId(int idRelevancia)
        {
            var query = _context.Set<Relevancia>()
                .Include(e => e.Id).AsSplitQuery()
                .Include(e => e.Descricao).AsSplitQuery()
                .Where(e => e.Id == idRelevancia);

            return query.FirstOrDefaultAsync();
        }
    }
}
