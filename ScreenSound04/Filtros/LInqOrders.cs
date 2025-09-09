using Screensound04.Modelos;

namespace Screensound04.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdernados(List<Musica> musicas)
    {
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musicas => musicas.Artista).Distinct().ToList();
        Console.WriteLine("Lista de artistas ordenados");
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }

    }
}