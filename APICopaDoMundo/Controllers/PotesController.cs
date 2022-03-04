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
    public class PotesController : ControllerBase
    {
        private readonly IPotesRepository _repository;

        public PotesController(IPotesRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Potes>>> GetPotes()
        {
            var potes = await _repository.ObterTodos();
            if (potes == null)
            {
                return BadRequest();
            }
            return Ok(potes);
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Potes>>> GetPotes(int id)
        {
            var potes = await _repository.ObterPorId(id);
            if (potes == null)
            {
                return BadRequest();
            }
            return Ok(potes);
        }

    }
}
