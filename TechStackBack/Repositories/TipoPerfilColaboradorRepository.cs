using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStackBack.IRepositories;
using TechStackProcesso.Data;
using TechStackProcesso.Models;

namespace TipoPerfilColaboradorBack.Repositories
{
    public class TipoPerfilColaboradorRepository: ITipoPerfilColaboradorRepository
    {
        private readonly AppDbContext _context;
        public TipoPerfilColaboradorRepository(AppDbContext context)
        {
            _context = context;
        }

    }
}
