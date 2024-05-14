using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechStackBack.DTO;
using TechStackBack.Filters;
using TechStackBack.Interfaces;
using TechStackProcesso.Data;
using TechStackProcesso.Models;

namespace TechStackBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ColaboradorController: ControllerBase
    {
        private readonly IColaboradorBusiness _colaboradorBusiness;

        public ColaboradorController(AppDbContext context, IColaboradorBusiness colaboradorBusiness)
        {
            _colaboradorBusiness = colaboradorBusiness;
        }

        [HttpGet("ObterColaboradores")]
        public async Task<IActionResult> ObterColaboradores()
        {
            var result = await _colaboradorBusiness.ObterColaboradores();
            return Ok(result);
        }

    }
}
