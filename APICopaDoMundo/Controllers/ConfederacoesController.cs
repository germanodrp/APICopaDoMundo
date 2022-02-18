using APICopaDoMundo.Contexto;
using APICopaDoMundo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace APICopaDoMundo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfederacoesController : ControllerBase
    {
        private readonly Context contexto;

        public ConfederacoesController()
        {
            contexto = new Context();
        }
        public ActionResult ObterTodasConfederacoes(int Id)
        {
            try
            {
                var ListarConfederacoes = new List<Confederacoes>(Id);
                return Ok(ListarConfederacoes);
            }
            catch
            {
                return BadRequest();
            }
        }

        
        
    }
}
