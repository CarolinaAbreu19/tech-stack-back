using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStackBack.IRepositories;
using TechStackProcesso.Data;
using TechStackProcesso.Models;

namespace TechStackBack.Repositories
{
    public class AreaConhecimentoRepository: IAreaConhecimentoRepository
    {
        private readonly AppDbContext _context;
        public AreaConhecimentoRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<AreaConhecimento> ObterPorId(int idArea)
        {
            var query = _context.Set<AreaConhecimento>()
                .Include(e => e.Id).AsSplitQuery()
                .Include(e => e.IdTechStack).AsSplitQuery()
                .Include(e => e.IdTipoConhecimento).AsSplitQuery()
                .Include(e => e.Descricao).AsSplitQuery()
                .Where(e => e.Id == idArea);

            return query.FirstOrDefaultAsync();
        }
    }
}
