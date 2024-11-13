using System;

namespace CarbonHeroes.Modelos;

internal class Quiz
{
	// Propriedades
	public List<Categoria> Categorias { get; set; }
	public Usuario Participante { get; set; }

	// Construtor
	public Quiz(string titulo, Usuario participante)
	{
		Participante = participante;
		Categorias = new List<Categoria>();
	}

	// Método para adicionar uma categoria ao quiz
	public void AdicionarCategoria(Categoria categoria)
	{
		Categorias.Add(categoria);
	}

	// Método para capturar respostas do participante (opcionalmente detalhado)
	public void CapturarResposta(int perguntaId, string resposta)
	{
		if (!string.IsNullOrWhiteSpace(resposta))
		{
			Participante.AdicionarResposta(new Resposta(perguntaId, resposta));
		}
		else
		{
			Console.WriteLine("Resposta inválida.");
		}
	}

	// Método para calcular a pegada de carbono com base nas respostas
	public double CalcularPegadaDeCarbono()
	{
		double totalEmissoes = 0.0;

		// Exemplo de cálculo simples baseado nas respostas
		foreach (var resposta in Participante.Respostas)
		{
			// Aqui, inclua a lógica para calcular emissões com base em `resposta` e a pergunta associada.
			// Por exemplo, use diferentes fatores de emissão com base no tipo de resposta.
		}

		Console.WriteLine($"Total de emissões calculadas: {totalEmissoes} kg de CO2");
		return totalEmissoes;
	}

}


