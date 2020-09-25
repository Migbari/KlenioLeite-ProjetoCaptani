using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCoreCapitani.Models
{
    public class EstadoCivilViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
