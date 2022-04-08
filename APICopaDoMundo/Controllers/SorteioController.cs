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
        [HttpPost]
        [Route("Sortear")]
        public ActionResult Sortear()
        {
            if (ExistePaisPote(contexto, 1))
            {
                SorteioCabecasDeChave(contexto);
            }
           
            return Ok("Pais Sorteado Com Sucesso");
        }
        
        private void SorteioPaisSede(Context dataContext)
        {

            var paisSede = dataContext.Paises.Where(p => p.Sede == true).First();
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
        }
        private void SorteioCabecasDeChave(Context dataContext)
        {
            var paisesPote1 = dataContext.PotePais.Where(p => p.IdPote == 1);

            if(paisesPote1.Count() == 8)
            {
                SorteioPaisSede(contexto);
            }
            else
            {
                var GrupoA = dataContext.Grupo.Where(g => g.Nome == "GrupoA").First();

                Random random = new Random();

                var paisCabecaChave = dataContext.PotePais.OrderBy(p => p.IdPais * random.Next()).First();
                //existe no grupo algum pais da minha mesma confederacao 

                var participanteCabecaChave = new ParticipantesGrupo()
                {
                    IdGrupo = GrupoA.Idgrupo,
                    Id = paisCabecaChave.IdPais
                };
                dataContext.ParticipantesGrupos.Add(participanteCabecaChave);

                dataContext.PotePais.Remove(paisCabecaChave);
            }
   
        }

        private bool ExistePaisPote(Context dataContext, int idPote)
        {
            return  dataContext.PotePais.Where(p => p.IdPote == idPote).Count() > 0;
        }
    }
}
