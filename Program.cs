using System;
using CarbonHeroes.Modelos;
using System.Threading;
using Spectre.Console;

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
			AnsiConsole.MarkupLine($"[bold]{titulo}[/]");
			Console.WriteLine(asteriscos + "\n");
		}

		void ExibirEmNegrito(string texto)
		{
			AnsiConsole.MarkupLine($"[bold]{texto}[/]");
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

		void EscreverTextoLetraPorLetra(string texto)
		{
			foreach (char letra in texto)
			{
				Console.Write(letra);
				Thread.Sleep(10); // Ajuste o tempo de espera conforme necessário
			}
		}

		void EntenderQuiz()
		{
			Console.Clear();
			ExibirLogo();
			ExibirTituloDaOpcao("Entendendo o Carbon Heroes Quiz");

			EscreverTextoLetraPorLetra($"O Carbon Heroes Quiz é uma aplicação interativa projetada para ajudar as pessoas a entender e calcular \nsua pegada de carbono de maneira envolvente e educativa. A pegada de carbono mede o impacto ambiental \ndas atividades diárias de uma pessoa, em termos de emissões de dióxido de carbono (CO2) e outros gases \nde efeito estufa, que contribuem para o aquecimento global e as mudanças climáticas.\n\n");

			EscreverTextoLetraPorLetra("No Carbon Heroes Quiz, os participantes respondem a uma série de perguntas sobre diferentes aspectos \nde suas rotinas, como uso de transporte, consumo de energia em casa e hábitos alimentares. Com base \nnas respostas fornecidas, a aplicação calcula a quantidade aproximada de CO2 emitida por cada atividade,\n resultando em uma estimativa da pegada de carbono pessoal do usuário.\n\n");

			EscreverTextoLetraPorLetra("A aplicação não só permite que os participantes compreendam melhor o impacto de suas ações no meio \nambiente, mas também transforma essa conscientização em uma experiência gamificada. Os usuários podem \ncomparar seus resultados com os de outros participantes, incentivando a adoção de práticas mais \nsustentáveis e a redução de suas emissões. O Carbon Heroes Quiz inspira as pessoas a se tornarem \nverdadeiros 'heróis do carbono', comprometidos com um futuro mais verde e sustentável.\n\n");


			Console.WriteLine("\nPressione qualquer tecla para retornar ao menu inicial...");
			Console.ReadKey();
			ExibirOpcoesDoMenuInicial();
		}

		void Iniciar()
		{
			ExibirOpcoesDoMenuInicial();
		}

		Iniciar();
	}
}

