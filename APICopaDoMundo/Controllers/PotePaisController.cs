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
    public class PotePaisController : ControllerBase
    {
        private readonly IPotePaisRepository _repository;

        public PotePaisController(IPotePaisRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [Route("ola")]
        public ActionResult ola()
        {
            return Ok("Pote pais chamando !");
        }

        [HttpGet]
        [Route("obterTodos")]
        public async Task<ActionResult<IEnumerable<PotePais>>> GetPotePais()
        {
            var potePais = await _repository.ObterTodos();
            if (potePais == null)
            {
                return BadRequest();
            }
            return Ok(potePais);
        }

        [HttpGet]
        [Route("obterPorId/{id}")]
        public async Task<ActionResult<IEnumerable<PotePais>>> GetPotePais(int id)
        {
            var potePais = await _repository.ObterPorId(id);
            if (potePais == null)
            {
                return BadRequest();
            }
            return Ok(potePais);
        }

        [HttpPost]
        [Route("adicionarPotePais")]
        public async Task<ActionResult<IEnumerable<PotePais>>> PostPotePaise(PotePais potePais)
        {

            if (potePais == null)
            {
                return BadRequest();
            }

            await _repository.Adicionar(potePais);

            return Ok(potePais);
        }

        [HttpPut]
        [Route("AtualizarPotePais/{id}")]

        public async Task<ActionResult<IEnumerable<PotePais>>> AtualizarPotePais(PotePais potePais, int id)


        {
            var atualizarPotePais = await _repository.ObterPorId(id);

            if (atualizarPotePais == null)
            {
                return BadRequest();
            }

            await _repository.Atualizar(atualizarPotePais);

            return Ok("Pais atualizado com sucesso!");
        }


        [HttpDelete]
        [Route("deletarPotePais/{id}")]

        public async Task<ActionResult<IEnumerable<PotePais>>> DeletePotePais(int id)


        {
            var deletePotePais = await _repository.ObterPorId(id);

            if (deletePotePais == null)
            {
                return BadRequest();
            }

            await _repository.Deletar(id);

            return Ok("Pais removido com sucesso!");
        }


    }
}
