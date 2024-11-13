using System;

namespace CarbonHeroes.Modelos;

internal class Categoria
{
	public string Nome { get; set; }
	public List<Pergunta> Perguntas { get; set; }
	public int IdPerguntaBooleana { get; set; }

	public Categoria(string nome)
	{
		Nome = nome;
		Perguntas = new List<Pergunta>();
	}

	public void AdicionarPerguntas(List<Pergunta> perguntas)
	{
		foreach (Pergunta pergunta in perguntas)
		{
			Perguntas.Add(pergunta);
		}
	}

	public override string ToString() => $"Categoria: {Nome}";
}

