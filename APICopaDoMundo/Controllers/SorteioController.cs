using APICopaDoMundo.Contexto;
using APICopaDoMundo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace APICopaDoMundo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SorteioController : ControllerBase
    {
        private readonly Context contexto;

        public SorteioController()
        {
            contexto = new Context();
        }
        public ActionResult Sortear(int Id)
        {
            List<Paises> TimesSorteados = new List<Paises>();
   
            return Ok();
        }
    }
}
