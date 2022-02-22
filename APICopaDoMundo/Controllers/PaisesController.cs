using APICopaDoMundo.Contexto;
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

        //private readonly IPaises ;

        //public PaisesController()
        //{
        //    contexto = new Context();
        //}

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Paises>>> GetProdutos()
        //{
        //    var alunos = await _repository.ObterTodos();
        //    if (alunos == null)
        //    {
        //        return BadRequest();
        //    }
        //    return Ok(alunos);
        //}
    }
}
