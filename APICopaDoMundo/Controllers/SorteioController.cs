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


            var dataContext3 = new Context();

            var paisNaoSede2 = dataContext3.Paises.Where(p => p.Sede == false).First();

            var GrupoC = dataContext3.Grupo.Where(g => g.Nome == "GrupoC").First();

            var participantePais2 = new ParticipantesGrupo()
            {
                IdGrupo = GrupoC.Idgrupo,
                Id = paisNaoSede2.Id
            };

            dataContext3.ParticipantesGrupos.Add(participantePais2);

            var pote3 = dataContext3.Potes.Where(p => p.IdPote == 3).First();

            var potePaisNaoSede2 = new PotePais()
            {
                IdPais = paisNaoSede2.Id,
                IdPote = pote3.IdPote
            };

            dataContext3.PotePais.Remove(potePaisNaoSede2);

            ///////////////////////////////////////////////////////////////////////////////////////////////////


            var dataContext4 = new Context();

            var paisNaoSede3 = dataContext4.Paises.Where(p => p.Sede == false).First();

            var GrupoD = dataContext4.Grupo.Where(g => g.Nome == "GrupoD").First();

            var participantePais3 = new ParticipantesGrupo()
            {
                IdGrupo = GrupoD.Idgrupo,
                Id = paisNaoSede3.Id
            };

            dataContext3.ParticipantesGrupos.Add(participantePais3);

            var pote4 = dataContext4.Potes.Where(p => p.IdPote == 4).First();

            var potePaisNaoSede3 = new PotePais()
            {
                IdPais = paisNaoSede3.Id,
                IdPote = pote4.IdPote
            };

            dataContext3.PotePais.Remove(potePaisNaoSede3);



            return Ok();
        }
        

    }
}
