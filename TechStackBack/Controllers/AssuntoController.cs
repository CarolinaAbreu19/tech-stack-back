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
    public class AssuntoController: ControllerBase
    {
        private readonly IAssuntoBusiness _assuntoBusiness;

        public AssuntoController(AppDbContext context, IAssuntoBusiness assuntoBusiness)
        {
            _assuntoBusiness = assuntoBusiness;
        }

        [HttpGet("ObterAssuntosPorAreaConhecimento/{idAreaConhecimento}")]
        [EnableCors("CORS_POLICY")]
        public async Task<IActionResult> ObterAssuntosPorAreaConhecimento([FromRoute] int idAreaConhecimento)
        {
            var result = await _assuntoBusiness.ObterAssuntosPorAreaConhecimento(idAreaConhecimento);
            return Ok(result);
        }

    }
}
