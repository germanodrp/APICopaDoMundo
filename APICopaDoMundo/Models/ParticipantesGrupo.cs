using System.ComponentModel.DataAnnotations;

namespace APICopaDoMundo.Models
{
    public class ParticipantesGrupo
    {
        [Key]

        public int IdGrupo { get; set; }
        public int Id { get; set; }
        public Paises Paises { get; set; }
        public Grupo Grupo { get; set; }
    }
}
