using Capitani.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppCoreCapitani.Models
{
    public class ClienteViewModel
    {
		[Key]
		public int Id { get; set; }
		
		[Required(ErrorMessage = "Nome é um campo obrigatório.")]
		[MinLength(5, ErrorMessage = "Nome não pode ter menos de 5 caracteres.")]
		public string name { get; set; }
		
		public EstadoCivil EstadoCivil { get; set; }
		public int EstadoCivilId { get; set; }
		public DateTime DataNascimento { get; set; }

		[MinLength(5, ErrorMessage = "Nome não pode ter menos de 5 caracteres.")]
		public string nameParceiro { get; set; }
		public DateTime? DataNascimentoParceiro { get; set; }
	}
}
