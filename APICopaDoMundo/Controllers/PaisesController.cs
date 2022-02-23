using APICopaDoMundo.Contexto;
using APICopaDoMundo.Interface;
using APICopaDoMundo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICopaDoMundo.Controllers
{


    [Route("api/paisescontroller")]
    [ApiController]
    public class PaisesController : ControllerBase
    {

        private readonly IPaisesRepository _repository;

        public PaisesController(IPaisesRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paises>>>GetPaises()
        {
            var paises = await _repository.ObterTodos();
            if(paises == null)
            {
                return BadRequest();
            }
            return Ok(paises);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Paises>>> GetPaises(int id)
        {
            var paises = await _repository.ObterPorId(id);
            if (paises == null)
            {
                return BadRequest();
            }
            return Ok(paises);
        }
    }
}
