using System.ComponentModel.DataAnnotations;

namespace APICopaDoMundo.Models
{
    public class Paises
    {
        [Key]
        public int Id { get; set; }
        public int IdConfederacoes { get; set; }
        public string Nome { get; set; }
        public int RankingFifa { get; set; }
        public bool Sede { get; set; }

    }
}
