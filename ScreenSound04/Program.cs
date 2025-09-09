using System.Text.Json;
using Screensound04.Modelos;
using Screensound04.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

        LinqFilter.FiltrarMusicasEmCSharp(musicas);

        // musicas[0].ExibirDetalhesDaMusica(); 
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
        //LinqOrder.ExibirListaDeArtistasOrdernados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "rock");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Linkin Park");
        //LinqFilter.FiltrarMusicasPorAno(musicas, 2000);

        // var musicasPreferidasDoGabriel = new MusicasPreferidas("Gabriel");
        // musicasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[1]);
        // musicasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[2]);
        // musicasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[3]);
        // musicasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[4]);
        // musicasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[5]);

        // musicasPreferidasDoGabriel.ExibirMusicasFavoritas();
        // musicasPreferidasDoGabriel.GerarArquivoJson();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}