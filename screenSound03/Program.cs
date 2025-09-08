using ScreenSound.Menus;
using ScreenSound.Modelos;
// using OpenAI;
// using OpenAI.Chat;

// var client = new OpenAIClient("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");

// var chat = new List<ChatMessage>
// {
//     new ChatMessage(ChatRole.User, "Faça um resumo em um parágrafo sobre a banda Beatles, pode ser informal")
// };

// var response = await client.ChatCompletions.CreateAsync(
//     model: "gpt-3.5-turbo",
//     messages: chat
// );

// Console.WriteLine(response.Choices[0].Message.Content);


Banda linkin = new("Linkin Park");
linkin.AdicionarNota(new Avaliacao(10));
linkin.AdicionarNota(new Avaliacao(8));
linkin.AdicionarNota(new Avaliacao(6));
Banda beatles = new("The Beatles");

Dictionary<string, Banda> bandasRegistradas = new();
bandasRegistradas.Add(linkin.Nome, linkin);
bandasRegistradas.Add(beatles.Nome, beatles);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegistrarBanda());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuAvaliarAlbum());
opcoes.Add(6, new MenuExibirDetalhes());
opcoes.Add(-1, new MenuSair());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 2.0!");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para registrar o álbum de uma banda");
    Console.WriteLine("Digite 3 para mostrar todas as bandas");
    Console.WriteLine("Digite 4 para avaliar uma banda");
    Console.WriteLine("Digite 5 para avaliar um álbum");
    Console.WriteLine("Digite 6 para exibir os detalhes de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(bandasRegistradas);
        if (opcaoEscolhidaNumerica > 0) ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }

}

ExibirOpcoesDoMenu();