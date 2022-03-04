using APICopaDoMundo.Contexto;
using APICopaDoMundo.Interface;
using APICopaDoMundo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICopaDoMundo.Controllers
{


    [Route("api/[controller]")]
    [ApiController]
    public class PaisesController : ControllerBase
    {

        private readonly IPaisesRepository _repository;

        public PaisesController(IPaisesRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("ola")]
        public ActionResult ola()
        {
            return Ok("OKKKKKK");
        }

        [HttpGet]
        [Route("obterTodos")]
        public async Task<ActionResult<IEnumerable<Paises>>> GetPaises()
        {
            var paises = await _repository.ObterTodos();
            if (paises == null)
            {
                return BadRequest();
            }
            return Ok(paises);
        }

        [HttpGet]
        [Route("obterPorId/{id}")]
        public async Task<ActionResult<IEnumerable<Paises>>> GetPaises(int id)
        {
            var paises = await _repository.ObterPorId(id);
            if (paises == null)
            {
                return BadRequest();
            }
            return Ok(paises);
        }

        [HttpPost]
        [Route("adicionarPais")]
        public async Task<ActionResult<IEnumerable<Paises>>> PostPaises(Paises paises)
        {
            paises = new Paises();

            if (paises == null)
            {
                return BadRequest();
            }

            await _repository.Adicionar(paises);

            return Ok(paises);
        }


        [HttpDelete]
        [Route("deletarPais/{id}")]

        public async Task<ActionResult<IEnumerable<Paises>>> DeletePaises(int id)


        {
            var deletePais = await _repository.ObterPorId(id);

            if(deletePais == null)
            {
                return BadRequest();
            }

            await _repository.Deletar(id);

            return Ok(deletePais);
        }



    }
}
