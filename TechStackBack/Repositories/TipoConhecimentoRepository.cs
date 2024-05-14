using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStackBack.IRepositories;
using TechStackProcesso.Data;
using TechStackProcesso.Models;

namespace TipoConhecimentoBack.Repositories
{
    public class TipoConhecimentoRepository: ITipoConhecimentoRepository
    {
        private readonly AppDbContext _context;
        public TipoConhecimentoRepository(AppDbContext context)
        {
            _context = context;
        }

    }
}
