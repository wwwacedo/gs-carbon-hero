using System;
using CarbonHeroes.Modelos;
using Spectre.Console;

namespace CarbonHeroes.ConsoleUI;

internal static class UI
{
	public static void ExibirLogo()
	{
		Console.Clear();
		Console.WriteLine(@"
░█████╗░░█████╗░██████╗░██████╗░░█████╗░███╗░░██╗  ██╗░░██╗███████╗██████╗░░█████╗░███████╗░██████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗████╗░██║  ██║░░██║██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝
██║░░╚═╝███████║██████╔╝██████╦╝██║░░██║██╔██╗██║  ███████║█████╗░░██████╔╝██║░░██║█████╗░░╚█████╗░
██║░░██╗██╔══██║██╔══██╗██╔══██╗██║░░██║██║╚████║  ██╔══██║██╔══╝░░██╔══██╗██║░░██║██╔══╝░░░╚═══██╗
╚█████╔╝██║░░██║██║░░██║██████╦╝╚█████╔╝██║░╚███║  ██║░░██║███████╗██║░░██║╚█████╔╝███████╗██████╔╝
░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚══╝  ╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚══════╝╚═════╝░
𝙿𝚘𝚠𝚎𝚛𝚎𝚍 𝚋𝚢 𝙵𝙸𝙰𝙿
");
	}

	public static void ExibirTituloDaOpcao(string titulo)
	{
		int quantidadeDeLetras = titulo.Length;
		string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
		Console.WriteLine(asteriscos);
		AnsiConsole.MarkupLine($"[blue]{titulo}[/]");
		Console.WriteLine(asteriscos + "\n");
	}

	public static void InformarOpcaoInvalida(int tempo)
	{
		for (int i = 3; i > 0; i--)
		{
			UI.ExibirLogo();
			AnsiConsole.MarkupLine("[red]Opção inválida![/]");
			Console.WriteLine($"Retornando em -> {i}");
			Thread.Sleep(tempo);
		}
	}

	public static void InformarFimDoQuiz(int tempo)
	{
		string mensagem = "Aguarde um momento enquanto processamos seu resultado...";
		for (int i = 0; i < mensagem.Length; i++)
		{
			UI.ExibirLogo();
			AnsiConsole.MarkupLine("[green]Fim do Quiz![/]");
			Console.WriteLine($"\n{mensagem}\n");
			string pontos = string.Empty.PadLeft(i, '█');
			Console.Write(pontos);
			Thread.Sleep(tempo);
		}
		Console.WriteLine(" OK!");
		Thread.Sleep(1000);
	}

	public static void EscreverTextoLetraPorLetra(string texto)
	{
		foreach (char letra in texto)
		{
			Console.Write(letra);
			Thread.Sleep(10); // Ajuste o tempo de espera conforme necessário
		}
	}

	public static void FornecerLinkParaResultado(Quiz quiz)
	{
		ExibirLogo();
		ExibirTituloDaOpcao("Resultado");
		AnsiConsole.Markup($"[white]Acesse já: [/]");
		AnsiConsole.Markup($"[cyan]{quiz.Link}[/]\n\n");
	}

	public static void PressionarQualquerTecla(string texto = "Pressione qualquer tecla para continuar...")
	{
		AnsiConsole.MarkupLine($"[green]{texto}[/]");
		Console.ReadKey();
	}

}
