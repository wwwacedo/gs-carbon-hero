using System;

namespace CarbonHeroes.Modelos;

internal class Resposta
{
	// Propriedades
	public int PerguntaId { get; set; }
	public string Valor { get; set; }

	// Construtor
	public Resposta(int perguntaId, string valor)
	{
		PerguntaId = perguntaId;
		Valor = valor;
	}

	// Método para exibir a resposta
	public override string ToString()
	{
		return $"PerguntaId: {PerguntaId}, Resposta: {Valor}";
	}
}

