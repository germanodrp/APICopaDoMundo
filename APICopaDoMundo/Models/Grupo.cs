﻿using System.ComponentModel.DataAnnotations;

namespace APICopaDoMundo.Models
{
    public class Grupo
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
