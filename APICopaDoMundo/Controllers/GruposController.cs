using APICopaDoMundo.Contexto;
using APICopaDoMundo.Interface;
using APICopaDoMundo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICopaDoMundo.Controllers
{
    [Route("api/grupos")]
    [ApiController]
    public class GruposController : ControllerBase
    {
        private readonly IGrupoRepository _repository;

        public GruposController(IGrupoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
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
