using System;

namespace CarbonHeroes.Modelos;

internal class Categoria
{
	// Propriedades
	public string Nome { get; set; }
	public List<Pergunta> Perguntas { get; set; }

	// Construtor
	public Categoria(string nome)
	{
		Nome = nome;
		Perguntas = new List<Pergunta>();
	}

	// Método para adicionar uma pergunta à categoria
	public void AdicionarPergunta(Pergunta pergunta)
	{
		if (pergunta != null)
		{
			Perguntas.Add(pergunta);
		}
		else
		{
			throw new ArgumentNullException(nameof(pergunta), "A pergunta não pode ser nula.");
		}
	}

	public override string ToString()
	{
		return $"Categoria: {Nome}";
	}
}

