using APICopaDoMundo.Contexto;
using APICopaDoMundo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APICopaDoMundo.Controllers
{


    [Route("api/paisescontroller")]
    [ApiController]
    public class PaisesController : ControllerBase
    {

        private readonly Context contexto;

        public PaisesController()
        {
            contexto = new Context();
        }

        //[HttpGet("obterPaisesPorConfederacao")]
        //public ActionResult obterPaisesPorConfederacao()
        //{
        //    try
        //    {

        //        var paises = Paises;
        //        return Ok();

        //    }
        //    catch
        //    {
        //        return BadRequest();
        //    }

        //}

        [HttpGet("obterPaises")]
        public ActionResult ObterPaises()
        {
            try
            {
                var obterPaises = new List<Paises>();
                return Ok(obterPaises);
            }
            catch
            {
                return BadRequest("Erro");
            }

        }




        //[HttpDelete("remover")]
        //public ActionResult remova(string id)
        //{
        //    var presultado = Context..find<Paises>(p => p.Id == id).firstordefault();
        //    if (presultado == null) return
        //            notfound("id não encontrado, atualizacao não realizada!");

        //    context._produtos.deleteone<paises>(filter => filter.id == id);
        //    return nocontent();
        //}
    }
}
