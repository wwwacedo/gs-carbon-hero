using System;

namespace CarbonHeroes.Modelos;

internal class Quiz
{
	public List<Categoria> Categorias { get; set; } = new();
	public string Link { get; set; } = string.Empty;

	public void AdicionarCategorias(List<Categoria> categorias)
	{
		foreach (Categoria categoria in categorias)
		{
			Categorias.Add(categoria);
		}
	}

	public void GerarLink(Usuario usuario)
	{
		string allParams = string.Empty;
		allParams += $"?nome={Uri.EscapeDataString(usuario.Nome)}";
		foreach (Categoria categoria in Categorias)
		{
			foreach (Pergunta pergunta in categoria.Perguntas)
			{
				if (pergunta.Resposta.Valor != 0)
				{
					if (pergunta.Tipo == TipoPergunta.Booleana)
					{
						allParams += $"&p{pergunta.Id}={(pergunta.Resposta.Valor == 1 ? "true" : "false")}";
					}
					else
					{
						allParams += $"&p{pergunta.Id}={pergunta.Resposta.Valor}";
					}
				}
			}
		}
		Link = $"https://carbon-heroes.vercel.app/resultado{allParams}";
	}

	public void ExibirInformacoes()
	{
		foreach (Categoria categoria in Categorias)
		{
			Console.WriteLine($"\n{categoria.Nome.ToUpper()}\n");
			foreach (Pergunta pergunta in categoria.Perguntas)
			{
				pergunta.ExibirInformacoes();
			}
		}
	}
}


