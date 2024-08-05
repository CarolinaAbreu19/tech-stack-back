using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStackBack.DTO;
using TechStackBack.IRepositories;
using TechStackProcesso.Data;
using TechStackProcesso.Models;

namespace TechStackBack.Repositories
{
    public class TechStackRepository: ITechStackRepository
    {
        private readonly AppDbContext _context;
        public TechStackRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<List<TechStack>> ConsultarTechStacks()
        {
            var query = _context.Set<TechStack>()
                .Include(t => t.Preenchimentos).AsSplitQuery();

            return query.ToListAsync();
        }
        
        public Task<TechStack> ConsultarTechStackPorId(int idTeckStack)
        {
            var query = _context.Set<TechStack>().AsSplitQuery()
                .Include(t => t.AreasConhecimento).AsSplitQuery()
                .Include(t => t.Preenchimentos)
                    .ThenInclude(t => t.Respostas).AsSplitQuery()
                .Where(t => t.Id == idTeckStack);

            return query.FirstOrDefaultAsync();
        }

    }
}
