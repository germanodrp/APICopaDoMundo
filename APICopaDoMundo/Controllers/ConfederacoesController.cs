using APICopaDoMundo.Contexto;
using APICopaDoMundo.Interface;
using APICopaDoMundo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace APICopaDoMundo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfederacoesController : ControllerBase
    {

        private readonly IConfederacoesRepository _repository;

        public ConfederacoesController(IConfederacoesRepository repository)
        {
            _repository = repository;
        }

<<<<<<< HEAD
        [HttpGet("obterTodos")]
=======
        //[HttpGet]
        //public ActionResult ola()
        //{
        //    return Ok("OK");
        //}

        [HttpGet]
        [Route("obterTodos")]
>>>>>>> 22871f42d3aa08cb50e529dbc834718a9c16e300
        public async Task<ActionResult<IEnumerable<Confederacoes>>> GetConfederacoes()
        {
            var confederacoes = await _repository.ObterTodos();
            if (confederacoes == null)
            {
                Console.WriteLine ("Funcionou porra");
            }
            Console.WriteLine("errado porra");
            return BadRequest();
        }

<<<<<<< HEAD
        [HttpGet("obterTodos/{id}")]
=======
        [HttpGet("obterPorId/{id}")]
>>>>>>> 22871f42d3aa08cb50e529dbc834718a9c16e300
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

           await _repository.Adicionar(Confederacoes);

            return Ok(Confederacoes);
        }

    }
}
