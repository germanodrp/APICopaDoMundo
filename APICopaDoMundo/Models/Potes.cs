using System.ComponentModel.DataAnnotations;

namespace APICopaDoMundo.Models
{
    public class Potes
    {
        [Key]
        public int IdPote { get; set; }    
        public string Descricao { get; set; }
    }
}
