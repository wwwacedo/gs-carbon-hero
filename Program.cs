using System;
using CarbonHeroes.Modelos;

class Program
{
	static void Main(string[] args)
	{

		void ExibirLogo()
		{
			System.Console.WriteLine(@"
░█████╗░░█████╗░██████╗░██████╗░░█████╗░███╗░░██╗  ██╗░░██╗███████╗██████╗░░█████╗░███████╗░██████╗
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔══██╗████╗░██║  ██║░░██║██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝
██║░░╚═╝███████║██████╔╝██████╦╝██║░░██║██╔██╗██║  ███████║█████╗░░██████╔╝██║░░██║█████╗░░╚█████╗░
██║░░██╗██╔══██║██╔══██╗██╔══██╗██║░░██║██║╚████║  ██╔══██║██╔══╝░░██╔══██╗██║░░██║██╔══╝░░░╚═══██╗
╚█████╔╝██║░░██║██║░░██║██████╦╝╚█████╔╝██║░╚███║  ██║░░██║███████╗██║░░██║╚█████╔╝███████╗██████╔╝
░╚════╝░╚═╝░░╚═╝╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚══╝  ╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝░╚════╝░╚══════╝╚═════╝░
𝙿𝚘𝚠𝚎𝚛𝚎𝚍 𝚋𝚢 𝙵𝙸𝙰𝙿
");
		}	

		void ExibirTituloDaOpcao(string titulo)
		{
			int quantidadeDeLetras = titulo.Length;
			string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
			Console.WriteLine(asteriscos);
			Console.WriteLine(titulo);
			Console.WriteLine(asteriscos + "\n");
		}

		void OpcaoInvalida(int tempo)
		{
			Console.WriteLine("\nOpção inválida! ");
			Console.Write("Retornando ao menu inicial");
			Thread.Sleep(tempo);
			Console.Write(".");
			Thread.Sleep(tempo);
			Console.Write(".");
			Thread.Sleep(tempo);
			Console.Write(".");
			Thread.Sleep(tempo);
		}

		void ExibirOpcoesDoMenuInicial()
		{
			Console.Clear();
			ExibirLogo();
			Console.WriteLine("Seja bem-vindo ao Carbon Heroes Quiz!");
			Console.WriteLine("\nDigite 1 para iniciar o Carbon Hero Quiz");
			Console.WriteLine("Digite 2 para entender mais sobre o projeto");
			Console.WriteLine("Digite -1 para sair");

			Console.Write("\nDigite a sua opção: ");
			string opcaoEscolhida = Console.ReadLine()!;
			if (int.TryParse(opcaoEscolhida, out int opcaoEscolhidaNumerica))
			{
				switch (opcaoEscolhidaNumerica)
				{
					case 1:
						IniciarQuiz();
						break;
					case 2:
						EntenderQuiz();
						break;
					case -1:
						Console.Clear();
						ExibirLogo();
						Console.WriteLine("\nOK, até a próxima! 🤚\n");
						break;
					default:
						Console.Clear();
						ExibirLogo();
						OpcaoInvalida(500);
						ExibirOpcoesDoMenuInicial();
						break;
				}
			}
			else
			{
				Console.Clear();
				ExibirLogo();
				OpcaoInvalida(500);
				ExibirOpcoesDoMenuInicial();
			}
		}


		void IniciarQuiz()
		{

		}

		void EntenderQuiz()
		{

		}

		void Iniciar()
		{
			ExibirOpcoesDoMenuInicial();
		}

		Iniciar();
	}
}

