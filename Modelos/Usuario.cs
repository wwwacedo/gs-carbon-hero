using System;

namespace CarbonHeroes.Modelos;

internal class Usuario
{
	// Propriedades
	public string Nome { get; set; }
	public List<Resposta> Respostas { get; set; }

	// Construtor
	public Usuario(string nome)
	{
		Nome = nome;
		Respostas = new List<Resposta>();
	}

	// Método para adicionar uma resposta à lista
	public void AdicionarResposta(Resposta resposta)
	{
		if (resposta != null)
		{
			Respostas.Add(resposta);
		}
		else
		{
			throw new ArgumentNullException(nameof(resposta), "A resposta não pode ser nula.");
		}
	}

	public override string ToString()
	{
		return $"Usuário: {Nome}";
	}
}
