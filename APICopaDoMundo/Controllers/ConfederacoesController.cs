using APICopaDoMundo.Contexto;
using APICopaDoMundo.Interface;
using APICopaDoMundo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICopaDoMundo.Controllers
{
    [Route("api/confederacoes")]
    [ApiController]
    public class ConfederacoesController : ControllerBase
    {

        private readonly IConfederacoesRepository _repository;

        public ConfederacoesController(IConfederacoesRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Confederacoes>>> GetConfederacoes()
        {
            var confederacoes = await _repository.ObterTodos();
            if (confederacoes == null)
            {
                return BadRequest();
            }
            return Ok(confederacoes);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Confederacoes>>> GetConfederacoes(int id)
        {
            var confederacoes = await _repository.ObterPorId(id);
            if (confederacoes == null)
            {
                return BadRequest();
            }
            return Ok(confederacoes);
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Confederacoes>>> PostConfederacoes(Confederacoes Confederacoes)
        {
             Confederacoes = new Confederacoes();

            if(Confederacoes == null)
            {
                return BadRequest();
            }

            _repository.Adicionar(Confederacoes);

            return Ok(Confederacoes);
        }

    }
}
