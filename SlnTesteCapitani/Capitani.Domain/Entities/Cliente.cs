//using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Capitani.Domain.Entities
{
    public class Cliente
	{
		[Key]
		public int Id { get; set; }
		[Required(ErrorMessage = "Nome é um campo obrigatório.")]
		[MinLength(5, ErrorMessage = "Nome não pode ter menos de 5 caracteres.")]
		public string Nome { get; set; }
		public EstadoCivil EstadoCivil { get; set; }
		public int EstadoCivilId { get; set; }
		public DateTime DataNascimento { get; set; }
		[MinLength(5, ErrorMessage = "Nome não pode ter menos de 5 caracteres.")]
		public string NomeParceiro { get; set; }
		public DateTime? DataNascimentoParceiro { get; set; }
		public bool Ativo { get; set; }
		public DateTime? DataInatividade { get; set; }

		//Essa é uma regra de Domínio de Entidade, conforme solicitado no escopo da parte interessada
		public bool IsValidParceiroCasado(Cliente cliente)
        {
			if(!string.IsNullOrEmpty(cliente.NomeParceiro) 
				|| (cliente.DataNascimentoParceiro != null && cliente.DataNascimentoParceiro != DateTime.MinValue))
            {
				if (cliente.EstadoCivilId == 1)
					return true;
				else
					return false;
			}
			return true;
        }
	}
}

