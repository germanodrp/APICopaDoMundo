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
    public class ParticipantesGrupoController : ControllerBase
    {
        private readonly IParticipantesGrupoRepository _repository;


        public ParticipantesGrupoController(IParticipantesGrupoRepository repository)
        {
            _repository = repository;
        }




        [HttpGet]
        [Route("ola")]
        public ActionResult ola()
        {
            return Ok("OK");
        }

        [HttpGet]
        [Route("obterTodos")]

        public async Task<ActionResult<IEnumerable<ParticipantesGrupo>>> GetPartcipantesGrupo()
        {
            var participantesGrupos = await _repository.ObterTodos();
            if (participantesGrupos == null)
            {
                Console.WriteLine("Funcionou porra");
            }
            Console.WriteLine("errado porra");
            return Ok(participantesGrupos);
        }




        [HttpGet]
        [Route("obterPorId/{id}")]


        public async Task<ActionResult<IEnumerable<ParticipantesGrupo>>> GetPartcipantesGrupo(int id)
        {
            var participantesGrupo = await _repository.ObterPorId(id);
            if (participantesGrupo == null)
            {
                return BadRequest();
            }
            return Ok(participantesGrupo);
        }

       

        [HttpDelete]
        [Route("deletarPais/{id}")]

        public async Task<ActionResult<IEnumerable<Paises>>> DeleteParticipantesGrupo(int id)


        {
            var deletePais = await _repository.ObterPorId(id);

            if (deletePais == null)
            {
                return BadRequest();
            }

            await _repository.Deletar(id);

            return Ok("Participante removido com sucesso!");
        }


    }
}
