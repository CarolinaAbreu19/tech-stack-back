using Microsoft.AspNetCore.Cors;
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
    public class TechStackController: ControllerBase
    {
        private readonly ITechStackBusiness _techStackBusiness;

        public TechStackController(AppDbContext context, ITechStackBusiness techStackBusiness)
        {
            _techStackBusiness = techStackBusiness;
        }

        [HttpGet("ObterTechStacks")]
        [EnableCors("CORS_POLICY")]
        public async Task<IActionResult> ObterTechStacks()
        {
            var result = await _techStackBusiness.ObterTechStacks();
            return Ok(result);
        }

    }
}
