using System;
using OpenAI.Chat;
using DotNetEnv;

namespace CarbonHeroes.Services;

public class OpenAIChat
{
	public static async Task<string> Test()
	{
		// Carregar o arquivo .env
		Env.Load();

		// Ler a variável de ambiente
		string? apiKey = Environment.GetEnvironmentVariable("OPENAI_API_KEY");

		if (string.IsNullOrEmpty(apiKey))
		{
			Console.WriteLine("Dica indisponível. OPENAI_API_KEY não encontrada no arquivo .env");
			return string.Empty;
		}

		try
		{

			string prompt = $"Dê uma dica curta de como reduzir a pegada de carbono. Quebre linha a cada frase. Use no máximo 200 caracteres. Exemplo: 'Compre produtos locais. Evite comprar produtos importados.'";

			ChatClient client = new(model: "gpt-4o", apiKey: apiKey);

			ChatCompletion completion = await client.CompleteChatAsync(prompt);

			return $"{completion.Content[0].Text}";
		}
		catch (Exception ex)
		{
			Console.WriteLine("ops! algo deu errado: " + ex.Message);
			return string.Empty;
		}
	}

}
