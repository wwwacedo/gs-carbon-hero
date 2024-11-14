using System;
using Spectre.Console;

namespace CarbonHeroes.Modelos;

internal class Pergunta
{
	public int Id { get; }
	public string Texto { get; }
	public TipoPergunta Tipo { get; }
	public Resposta Resposta { get; set; }

	public Pergunta(int id, string texto, TipoPergunta tipo, string? unidadeResposta = null, float? fator = null)
	{
		Id = id;
		Texto = texto;
		Tipo = tipo;
		Resposta = new Resposta(unidadeResposta);
	}

	public void ExibirInformacoes()
	{
		Console.WriteLine($"{Id}. {Texto} - {Resposta} - {Tipo}");
	}

	// Método opcional para exibir a pergunta (para testes/debug)
	public override string ToString()
	{
		string texto = $"{Texto} ";
		texto += Tipo == TipoPergunta.Numerica ? "(digite um número)" : "(digite 1 para 'Sim' ou 2 para 'Não')";
		switch (Tipo)
		{
			case TipoPergunta.Booleana:
				texto += "\n\n1. Sim\n2. Não";
				break;
		}
		return texto;
	}
}

internal enum TipoPergunta
{
	Numerica,
	Booleana
}
