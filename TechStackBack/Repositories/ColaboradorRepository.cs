using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStackBack.IRepositories;
using TechStackProcesso.Data;
using TechStackProcesso.Models;

namespace TechStackBack.Repositories
{
    public class ColaboradorRepository: IColaboradorRepository
    {
        private readonly AppDbContext _context;
        public ColaboradorRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<List<Colaborador>> ConsultarColaboradores()
        {
            var query = _context.Set<Colaborador>();

            return query.ToListAsync();
        }
    }
}
