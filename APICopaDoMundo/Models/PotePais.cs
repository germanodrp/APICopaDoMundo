using System.ComponentModel.DataAnnotations;

namespace APICopaDoMundo.Models
{
    public class PotePais
    {
        [Key]

        public int IdPote { get; set; }

        public int IdPais { get; set; }

        public Potes potes { get; set; }
    }
}
