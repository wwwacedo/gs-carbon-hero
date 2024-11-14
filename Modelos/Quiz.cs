using System;

namespace CarbonHeroes.Modelos;

internal class Quiz
{
	public List<Categoria> Categorias { get; set; } = new();

	public void AdicionarCategorias(List<Categoria> categorias)
	{
		foreach (Categoria categoria in categorias)
		{
			Categorias.Add(categoria);
		}
	}

}


