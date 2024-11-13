using System;

namespace CarbonHeroes.Modelos;

internal class Usuario(string nome)
{
	public string Nome { get; set; } = nome;

	public override string ToString() => $"Usuário: {Nome}";

}
