using System;

public class Cliente
{
	public int Id { get; set; }
	public string Nome { get; set; }
	public int EstadoCivilId { get; set; }
	public DateTime DataNascimento { get; set; }
    public string? NomeParceiro { get; set; }
	public DateTime? DataNascimentoParceiro { get; set; }
}
