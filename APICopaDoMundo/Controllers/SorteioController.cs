using APICopaDoMundo.Contexto;
using APICopaDoMundo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

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
        //public ActionResult Sortear(int Id)
        //{
        //    List<Paises> TimesSorteados = new List<Paises>();
   
        //    return Ok();
        //}

        public ActionResult Sorteio()
        {
            var dataContext = new Context();
            //select * from Paises Where Sede = 'True'
            var paisSede = dataContext.Paises.Where( p => p.Sede == true).First();
            //select * from Grupo Where nome = 'Grupo A'
            var GrupoA = dataContext.Grupo.Where(g => g.Nome == "Grupo A").First();


            //adicionar ele no grupo A na posicao 1
            var participanteSede = new ParticipantesGrupo()
            {
                IdGrupo = GrupoA.Idgrupo,
                Id = paisSede.Id
            };
            dataContext.ParticipantesGrupos.Add(participanteSede);

            //dataContext.Potes.Remove();

                return Ok();
        }
        

    }
}
