using System;

namespace CarbonHeroes.Modelos;

internal class Quiz
{
	public List<Categoria> Categorias { get; set; } = new();

	public void AdicionarCategoria(Categoria categoria)
	{
		Categorias.Add(categoria);
	}

}


