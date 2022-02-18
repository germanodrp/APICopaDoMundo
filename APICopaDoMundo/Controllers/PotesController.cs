using APICopaDoMundo.Contexto;
using APICopaDoMundo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICopaDoMundo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PotesController : ControllerBase
    {
        private readonly Context contexto;

        public PotesController()
        {
            contexto = new Context();
        }
        public ActionResult ObterPotes()
        {
            return Ok();
        }

        [HttpPost]
        public ActionResult Inserir(Potes potes)
        {
          //  var resultado = Context._Potes.Find<Potes>(p => p.IdPote == potes.IdPote).FirstOrDefault();
            return Ok();
        }
    }
}
