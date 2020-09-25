//using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Capitani.Domain.Entities
{
    public class Cliente
	{
		[Key]
		//[JsonProperty("id")]
		public int Id { get; set; }

		[Required(ErrorMessage = "Nome é um campo obrigatório.")]
		[MinLength(5, ErrorMessage = "Nome não pode ter menos de 5 caracteres.")]
		//[JsonProperty("nome")]
		public string Nome { get; set; }
		
		//[JsonProperty("estadoCivil")]
		public EstadoCivil EstadoCivil { get; set; }

		//[JsonProperty("estadoCivilId")]
		public int EstadoCivilId { get; set; }

		//[JsonProperty("dataNascimento")]
		public DateTime DataNascimento { get; set; }

		[MinLength(5, ErrorMessage = "Nome não pode ter menos de 5 caracteres.")]
		//[JsonProperty("nomeParceiro")]
		public string NomeParceiro { get; set; }

		//[JsonProperty("dataNascimentoParceiro")]
		public DateTime? DataNascimentoParceiro { get; set; }

		//[JsonProperty("ativo")]
		public bool Ativo { get; set; }

		//[JsonProperty("dataInatividade")]
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

