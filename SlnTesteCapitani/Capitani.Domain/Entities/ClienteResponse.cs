using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Capitani.Domain.Entities
{
    public class ClienteResponse
    {
		[JsonProperty("id")]
		public int Id { get; set; }
		[JsonProperty("nome")]
		public string Nome { get; set; }
		[JsonProperty("estadoCivil")]
		public EstadoCivil EstadoCivil { get; set; }
		[JsonProperty("estadoCivilId")]
		public int EstadoCivilId { get; set; }
		[JsonProperty("dataNascimento")]
		public DateTime DataNascimento { get; set; }
		[JsonProperty("nomeParceiro")]
		public string NomeParceiro { get; set; }
		[JsonProperty("dataNascimentoParceiro")]
		public DateTime? DataNascimentoParceiro { get; set; }
		public bool Ativo { get; set; }
		[JsonProperty("dataInatividade")]
		public DateTime? DataInatividade { get; set; }
	}
}
