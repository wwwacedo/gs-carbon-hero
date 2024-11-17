using System;

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
		Console.Write($"{Id}. {Texto} - ");
		string resposta = string.Empty;
		if (Tipo == TipoPergunta.Booleana)
		{
			resposta = Resposta.Valor == 1 ? "true" : "false";
		}
		else
		{
			resposta = $"{Resposta.Valor} {Resposta.Unidade}";
		}
		Console.WriteLine($"{resposta}");
	}


	public override string ToString()
	{
		string texto = $"{Texto} ";
		texto += Tipo == TipoPergunta.Numerica ? "(digite um número)" : "(digite 1 para 'Sim' ou 2 para 'Não')";
		if (Tipo == TipoPergunta.Booleana)
		{
			texto += "\n\n1. Sim\n2. Não";
		}
		return texto;
	}
}

internal enum TipoPergunta
{
	Numerica,
	Booleana
}
