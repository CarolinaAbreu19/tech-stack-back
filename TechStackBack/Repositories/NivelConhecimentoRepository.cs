using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStackBack.IRepositories;
using TechStackProcesso.Data;
using TechStackProcesso.Models;

namespace TechStackBack.Repositories
{
    public class NivelConhecimentoRepository: INivelConhecimentoRepository
    {
        private readonly AppDbContext _context;
        public NivelConhecimentoRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<NivelConhecimento> ObterPorId(int idNivelConhecimento)
        {
            var query = _context.Set<NivelConhecimento>()
                .Include(e => e.Id).AsSplitQuery()
                .Include(e => e.Descricao).AsSplitQuery()
                .Where(e => e.Id == idNivelConhecimento);

            return query.FirstOrDefaultAsync();
        }
    }
}
