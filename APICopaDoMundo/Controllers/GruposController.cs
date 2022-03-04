using APICopaDoMundo.Contexto;
using APICopaDoMundo.Interface;
using APICopaDoMundo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICopaDoMundo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GruposController : ControllerBase
    {
        private readonly IGrupoRepository _repository;

        public GruposController(IGrupoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("ola")]
        public ActionResult ola()
        {
            return Ok("positivo");
        }

        [HttpGet]
        [Route("obterTodos")]
        public async Task<ActionResult<IEnumerable<Grupo>>> GetGrupo()
        {
            var grupos = await _repository.ObterTodos();
            if (grupos == null)
            {
                return BadRequest();
            }
            return Ok(grupos);
        }

        [HttpGet]
        [Route("obterPorId/{id}")]
        public async Task<ActionResult<IEnumerable<Grupo>>> GetGrupo(int id)
        {
            var grupos = await _repository.ObterPorId(id);
            if (grupos == null)
            {
                return BadRequest();
            }
            return Ok(grupos);
        }
    }
}
