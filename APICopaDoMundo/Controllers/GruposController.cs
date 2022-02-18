using APICopaDoMundo.Contexto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APICopaDoMundo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GruposController : ControllerBase
    {
        private readonly Context contexto;

        public GruposController()
        {
            contexto = new Context();
        }

        public ActionResult ObterGrupos()
        {
            return Ok();
        }
    }
}
