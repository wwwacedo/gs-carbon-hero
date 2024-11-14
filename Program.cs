using System;
using CarbonHeroes.Modelos;
using Spectre.Console;

class Program
{
	static void Main(string[] args)
	{
		const int TempoOpcaoInvalida = 800;

		Categoria categoria1 = new Categoria("Transporte Individual");
		Pergunta pergunta1 = new Pergunta(1, "Você possui carro?", TipoPergunta.Booleana);
		categoria1.IdPerguntaBooleana = pergunta1.Id;
		Pergunta pergunta2 = new Pergunta(2, "Quantas pessoas em média são transportadas no seu carro?", TipoPergunta.Numerica, "pessoa(s)");
		Pergunta pergunta3 = new Pergunta(3, "Qual o seu consumo semanal de gasolina (em litros)?", TipoPergunta.Numerica, "litro(s)");
		Pergunta pergunta4 = new Pergunta(4, "Qual o seu consumo semanal de etanol (em litros)?", TipoPergunta.Numerica, "litro(s)");
		Pergunta pergunta5 = new Pergunta(5, "Qual o seu consumo semanal de diesel (em litros)?", TipoPergunta.Numerica, "litro(s)");
		Pergunta pergunta6 = new Pergunta(6, "Qual o seu consumo semanal de GNV (em m3)?", TipoPergunta.Numerica, "metro(s) cúbico(s)");
		categoria1.AdicionarPerguntas(new List<Pergunta> { pergunta1, pergunta2, pergunta3, pergunta4, pergunta5, pergunta6 });

		Categoria categoria2 = new Categoria("Transporte Coletivo | Ônibus");
		Pergunta pergunta7 = new Pergunta(7, "Você utiliza ônibus?", TipoPergunta.Booleana);
		categoria2.IdPerguntaBooleana = pergunta7.Id;
		Pergunta pergunta8 = new Pergunta(8, "Quantas viagens por semana você faz de ônibus?", TipoPergunta.Numerica, "viagem(ns)");
		Pergunta pergunta9 = new Pergunta(9, "Quantos km em média por viagem?", TipoPergunta.Numerica, "km");
		categoria2.AdicionarPerguntas(new List<Pergunta> { pergunta7, pergunta8, pergunta9 });

		Categoria categoria3 = new Categoria("Transporte Coletivo | Metrô ou Trem");
		Pergunta pergunta10 = new Pergunta(10, "Você utiliza metrô?", TipoPergunta.Booleana);
		categoria3.IdPerguntaBooleana = pergunta10.Id;
		Pergunta pergunta11 = new Pergunta(11, "Quantas viagens por semana você faz de metrô ou trem?", TipoPergunta.Numerica, "viagem(ns)");
		Pergunta pergunta12 = new Pergunta(12, "Quantos km em média por viagem?", TipoPergunta.Numerica, "km");
		categoria3.AdicionarPerguntas(new List<Pergunta> { pergunta10, pergunta11, pergunta12 });

		Categoria categoria4 = new Categoria("Transporte Aéreo");
		Pergunta pergunta13 = new Pergunta(13, "Você viajou de avião nos últimos 12 meses?", TipoPergunta.Booleana);
		categoria4.IdPerguntaBooleana = pergunta13.Id;
		Pergunta pergunta14 = new Pergunta(14, "Quantas viagens de curta distância (até 1.000 km) você fez nos últimos 12 meses (ida e volta = 1 viagem)?", TipoPergunta.Numerica, "viagem(ns)");
		Pergunta pergunta15 = new Pergunta(15, "Quantas viagens de média distância (1.000 a 3.700 km) você fez nos últimos 12 meses (ida e volta = 1 viagem)?", TipoPergunta.Numerica, "viagem(ns)");
		Pergunta pergunta16 = new Pergunta(16, "Quantas viagens de longa distância (mais de 5.000 km) você fez nos últimos 12 meses (ida e volta = 1 viagem)?", TipoPergunta.Numerica, "viagem(ns)");
		categoria4.AdicionarPerguntas(new List<Pergunta> { pergunta13, pergunta14, pergunta15, pergunta16 });

		Categoria categoria5 = new Categoria("Energia em Casa | Energia Elétrica");
		Pergunta pergunta17 = new Pergunta(17, "Qual é o seu consumo mensal de energia elétrica (em kWh)?", TipoPergunta.Numerica, "kWh");
		Pergunta pergunta18 = new Pergunta(18, "Quantas pessoas moram na sua casa?", TipoPergunta.Numerica, "pessoa(s)");
		categoria5.AdicionarPerguntas(new List<Pergunta> { pergunta17, pergunta18 });

		Categoria categoria6 = new Categoria("Energia em Casa | Gás de Cozinha | Botijão");
		Pergunta pergunta19 = new Pergunta(19, "Você usa botijão de gás em casa?", TipoPergunta.Booleana);
		categoria6.IdPerguntaBooleana = pergunta19.Id;
		Pergunta pergunta20 = new Pergunta(20, "Quantos meses dura um botijão de gás na sua casa?", TipoPergunta.Numerica, "mes(es)");
		categoria6.AdicionarPerguntas(new List<Pergunta> { pergunta19, pergunta20 });

		Categoria categoria7 = new Categoria("Energia em Casa | Gás de Cozinha | Encanado");
		Pergunta pergunta21 = new Pergunta(21, "Você usa gás encanado em casa?", TipoPergunta.Booleana);
		categoria7.IdPerguntaBooleana = pergunta21.Id;
		Pergunta pergunta22 = new Pergunta(22, "Qual é o seu consumo de gás encanado mensal (em m3)?", TipoPergunta.Numerica, "metro(s) cúbico(s)");
		categoria7.AdicionarPerguntas(new List<Pergunta> { pergunta21, pergunta22 });

		Categoria categoria8 = new Categoria("Alimentação");
		Pergunta pergunta23 = new Pergunta(23, "Você consome produtos de origem animal? (carnes, leite, ovos, etc)", TipoPergunta.Booleana);
		categoria8.IdPerguntaBooleana = pergunta23.Id;
		Pergunta pergunta24 = new Pergunta(24, "Quanta carne bovina você consome por semana (em kg)?", TipoPergunta.Numerica, "kg(s)");
		Pergunta pergunta25 = new Pergunta(25, "Quanta carne de frango você consome por semana (em kg)?", TipoPergunta.Numerica, "kg(s)");
		Pergunta pergunta26 = new Pergunta(26, "Quanta carne suína você consome por semana (em kg)?", TipoPergunta.Numerica, "kg(s)");
		Pergunta pergunta27 = new Pergunta(27, "Quanto leite de vaca você consome por semana (em litros)?", TipoPergunta.Numerica, "litro(s)");
		Pergunta pergunta28 = new Pergunta(28, "Quantos ovos você consome por semana (em unidades)?", TipoPergunta.Numerica, "unidade(s)");
		categoria8.AdicionarPerguntas(new List<Pergunta> { pergunta23, pergunta24, pergunta25, pergunta26, pergunta27, pergunta28 });

		Quiz quiz = new Quiz();
		quiz.AdicionarCategorias(new List<Categoria> { categoria1, categoria2, categoria3, categoria4, categoria5, categoria6, categoria7, categoria8 });

		void ExibirLogo()
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

		void ExibirTituloDaOpcao(string titulo)
		{
			int quantidadeDeLetras = titulo.Length;
			string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
			Console.WriteLine(asteriscos);
			AnsiConsole.MarkupLine($"[blue]{titulo}[/]");
			Console.WriteLine(asteriscos + "\n");
		}

		void OpcaoInvalida(int tempo)
		{
			for (int i = 3; i > 0; i--)
			{
				ExibirLogo();
				AnsiConsole.MarkupLine("[red]Opção inválida![/]");
				Console.WriteLine($"Retornando em -> {i}");
				Thread.Sleep(tempo);
			}
		}

		void ExibirOpcoesDoMenuInicial()
		{
			ExibirLogo();
			Console.WriteLine("Seja bem-vindo ao Carbon Heroes Quiz!");
			Console.WriteLine("\nDigite 1 para iniciar o Carbon Hero Quiz");
			Console.WriteLine("Digite 2 para entender mais sobre o Carbon Heroes Quiz");
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
						ExibirLogo();
						Console.WriteLine("OK, até a próxima! 🤚\n");
						break;
					default:
						OpcaoInvalida(TempoOpcaoInvalida);
						ExibirOpcoesDoMenuInicial();
						break;
				}
			}
			else
			{
				OpcaoInvalida(TempoOpcaoInvalida);
				ExibirOpcoesDoMenuInicial();
			}
		}

		void PressionarTeclaParaContinuar()
		{
			AnsiConsole.MarkupLine("[green]Pressione qualquer tecla para continuar...[/]");
			Console.ReadKey();
		}

		void IniciarQuiz()
		{
			ExibirLogo();
			ExibirTituloDaOpcao("Carbon Heroes Quiz");
			EscreverTextoLetraPorLetra("Ótimo! Vamos começar.");
			Console.WriteLine();

			// Criar um novo usuário
			string nome;
			do
			{
				EscreverTextoLetraPorLetra("- Digite seu nome: ");
				nome = Console.ReadLine()!;
				if (string.IsNullOrWhiteSpace(nome))
				{
					AnsiConsole.MarkupLine("[red]Nome não pode ser vazio. Por favor, digite seu nome.[/]");
				}
			} while (string.IsNullOrWhiteSpace(nome));
			Usuario usuario = new Usuario(nome);

			// Chavencando o usuário antes das perguntas
			ExibirLogo();
			ExibirTituloDaOpcao("Carbon Heroes Quiz");
			EscreverTextoLetraPorLetra($"{usuario.Nome.ToUpper()}, bonito nome! ;)");
			EscreverTextoLetraPorLetra("\nVamos calcular a sua pegada de carbono nos últimos 12 meses.");
			EscreverTextoLetraPorLetra("\nPara isso, você responderá a uma série de perguntas sobre seus hábitos diários/semanais.\n");
			EscreverTextoLetraPorLetra("\nPodemos começar?\n\n");
			PressionarTeclaParaContinuar();

			// Iniciando as perguntas
			foreach (Categoria categoria in quiz.Categorias)
			{
				foreach (Pergunta pergunta in categoria.Perguntas)
				{
					ExibirLogo();
					ExibirTituloDaOpcao("Carbon Heroes Quiz");
					AnsiConsole.Markup("[gray]Categoria: [/]");
					AnsiConsole.Markup($"[cyan]{categoria.Nome.ToUpper()}[/]\n");
					while (true)
					{
						// Exibir a pergunta
						AnsiConsole.Markup("[gray]Pergunta: [/]");
						EscreverTextoLetraPorLetra(pergunta.ToString());
						Console.Write("\nResposta: ");
						// Obter a resposta
						string valor = Console.ReadLine()!;

						// Validar a resposta com base no tipo da pergunta
						if (pergunta.Tipo == TipoPergunta.Numerica)
						{
							if (!double.TryParse(valor, out _))
							{
								AnsiConsole.MarkupLine("[red]Resposta inválida. Por favor, digite um número.[/]");
								continue;
							}
						}
						else if (pergunta.Tipo == TipoPergunta.Booleana)
						{
							if (valor != "1" && valor != "2")
							{
								AnsiConsole.MarkupLine("[red]\nResposta inválida. Por favor, digite 1 ou 2.\n[/]");
								continue;
							}
						}

						// Atualizar o valor da resposta na pergunta
						pergunta.Resposta.Valor = double.Parse(valor);
						break;
					}
					if (pergunta.Id == categoria.IdPerguntaBooleana && pergunta.Resposta.Valor == 2) break;
				}
			}
			System.Console.WriteLine("\nResultado do Quiz\n");
			quiz.GerarLink(usuario);
			AnsiConsole.MarkupLine($"[green]Link para o resultado: {quiz.Link}[/]");
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
			ExibirLogo();
			ExibirTituloDaOpcao("Entendendo o Carbon Heroes Quiz");

			EscreverTextoLetraPorLetra($"O Carbon Heroes Quiz é uma aplicação interativa projetada para ajudar as pessoas a entender e calcular \nsua pegada de carbono de maneira envolvente e educativa. A pegada de carbono mede o impacto ambiental \ndas atividades diárias de uma pessoa, em termos de emissões de dióxido de carbono (CO2) e outros gases \nde efeito estufa, que contribuem para o aquecimento global e as mudanças climáticas.\n\n");

			EscreverTextoLetraPorLetra("No Carbon Heroes Quiz, os participantes respondem a uma série de perguntas sobre diferentes aspectos \nde suas rotinas, como uso de transporte, consumo de energia em casa e hábitos alimentares. Com base \nnas respostas fornecidas, a aplicação calcula a quantidade aproximada de CO2 emitida por cada atividade, \nresultando em uma estimativa da pegada de carbono pessoal do usuário.\n\n");

			EscreverTextoLetraPorLetra("A aplicação não só permite que os participantes compreendam melhor o impacto de suas ações no meio \nambiente, mas também transforma essa conscientização em uma experiência gamificada. Os usuários podem \ncomparar seus resultados com os de outros participantes, incentivando a adoção de práticas mais \nsustentáveis e a redução de suas emissões. O Carbon Heroes Quiz inspira as pessoas a se tornarem \nverdadeiros 'heróis do carbono', comprometidos com um futuro mais verde e sustentável.\n\n");


			PressionarTeclaParaContinuar();
			ExibirOpcoesDoMenuInicial();
		}

		ExibirOpcoesDoMenuInicial();

	}
}

