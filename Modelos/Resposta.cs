using System;

namespace CarbonHeroes.Modelos;

internal class Resposta
{
	public double Valor { get; set; }
	public string? Unidade { get; set; }

	public Resposta(string? unidade = null)
	{
		Unidade = unidade;
	}
}
