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
    public class RespostaController: ControllerBase
    {
        private readonly IRespostaBusiness _respostaBusiness;

        public RespostaController(AppDbContext context, IRespostaBusiness respostaBusiness)
        {
            _respostaBusiness = respostaBusiness;
        }

        [HttpGet("ObterRespostasColaborador")]
        public async Task<IActionResult> ObterRespostasColaborador([FromBody] int idColaborador)
        {
            var result = await _respostaBusiness.ObterRespostasColaborador(idColaborador);
            return Ok(result);
        }

    }
}
