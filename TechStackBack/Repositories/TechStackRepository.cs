using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            var query = _context.Set<TechStack>();

            return query.ToListAsync();
        }
    }
}
