using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace APICopaDoMundo.Models
{
    public class Confederacoes
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sigla { get; set; }
        //public List<Paises> Paises { get; set; }
    }
}
