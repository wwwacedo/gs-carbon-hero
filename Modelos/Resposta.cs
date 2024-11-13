using System;

namespace CarbonHeroes.Modelos;

public class Resposta
{
	public double Valor { get; set; }
	public string? Unidade { get; set; }

	public Resposta(string? unidade = null)
	{
		Unidade = unidade;
	}
}
