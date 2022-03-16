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
            var GrupoA = dataContext.Grupo.Where(g => g.Nome == "GrupoA").First();


            //adicionar ele no grupo A na posicao 1
            var participanteSede = new ParticipantesGrupo()
            {
                IdGrupo = GrupoA.Idgrupo,
                Id = paisSede.Id
            };
            dataContext.ParticipantesGrupos.Add(participanteSede);

            var pote = dataContext.Potes.Where(p => p.IdPote == 1).FirstOrDefault();

            var potePaisSede = new PotePais()
            {
                IdPais = paisSede.Id,
                IdPote = pote.IdPote        
            };

           dataContext.PotePais.Remove(potePaisSede);
/////////////////////////////////////////////////////////////////////////////////////////////////

            var dataContext2 = new Context();

            var paisNaoSede = dataContext2.Paises.Where(p => p.Sede == false).First();

            var GrupoB = dataContext2.Grupo.Where(g => g.Nome == "GrupoB").First();

            var participantePais = new ParticipantesGrupo()
            {
                IdGrupo = GrupoB.Idgrupo,
                Id = paisNaoSede.Id
            };

            dataContext2.ParticipantesGrupos.Add(participantePais);

            var pote2 = dataContext2.Potes.Where(p => p.IdPote == 2).First();

            var potePaisNaoSede = new PotePais()
            {
                IdPais = paisNaoSede.Id,
                IdPote = pote2.IdPote
            };

            dataContext2.PotePais.Remove(potePaisNaoSede);

            //buscar alguem do pote 2
            //participante
            //add esse alguem no grupo a
            //dataContext.ParticipantesGrupos.Add(participante2);
            //buscar o id do pote 2
            //remover do pote 2
            ////////////////////////////////////////////////////////////////////////////////////////////////
            





            return Ok();
        }
        

    }
}
