using Screensound04.Modelos;
namespace Screensound04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
        foreach (var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero!.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Exibindo os artistas por gênero musical >>> {genero}");
        foreach (var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasDeUmArtista(List<Musica> musicas, string artista)
    {
        var musicasDoArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList();
        Console.WriteLine(artista);
        foreach (var musica in musicasDoArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasPorAno(List<Musica> musicas, int ano)
    {
        var musicasPorAno = musicas.Where(musica => musica.Ano == ano).OrderBy(musicas => musicas.Nome).Select(musicas => musicas.Nome).Distinct().ToList();
        Console.WriteLine($"{ano}");
        foreach (var musica in musicasPorAno) 
        {
            Console.WriteLine($"{musica}");
        }
    }

    internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
    {
        var musicasEmCSharp = musicas
        .Where(musica => musica.Tonalidade.Equals("C#"))
        .Select(musica => musica.Nome)
        .Distinct()
        .ToList();
        Console.WriteLine("Música em C#: ");

        foreach (var musica in musicasEmCSharp)
        {
            Console.WriteLine($"- {musica}");
        }
    }
}