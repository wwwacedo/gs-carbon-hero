using System;

namespace CarbonHeroes.Modelos;

internal class Pergunta
{
	// Propriedades
	public int Id { get; }
	public string Texto { get; }
	public TipoPergunta Tipo { get; }

	// Construtor
	public Pergunta(int id, string texto, TipoPergunta tipo)
	{
		Id = id;
		Texto = texto;
		Tipo = tipo;
	}

	// Método para validar a resposta fornecida pelo usuário
	public bool ValidarResposta(string resposta)
	{
		if (resposta == null)
		{
			throw new ArgumentNullException(nameof(resposta), "A resposta não pode ser nula.");
		}

		return Tipo switch
		{
			TipoPergunta.Numerica => double.TryParse(resposta, out _),// Valida se é numérica
			TipoPergunta.Texto => !string.IsNullOrWhiteSpace(resposta),// Valida se não é vazia
			TipoPergunta.EscolhaMultipla => !string.IsNullOrWhiteSpace(resposta),// Para simplificação, assume que as respostas válidas são verificadas separadamente
			_ => false,// Caso o tipo não seja reconhecido
		};
	}

	// Método opcional para exibir a pergunta (para testes/debug)
	public override string ToString()
	{
		return $"Id: {Id}, Pergunta: {Texto}, Tipo: {Tipo}";
	}
}

// Enumeração para diferenciar os tipos de resposta
internal enum TipoPergunta
{
	Numerica,
	Texto,
	EscolhaMultipla
}

