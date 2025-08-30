namespace Atividades.Alura;

class Artista
{
    public int Idade { get; set; }
    public string Nome { get; set; }
    public List<Filme> FilmeAtuado { get; set; }
    public int QtdDeFilmes => FilmeAtuado.Count;

    public Artista(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
        FilmeAtuado = new List<Filme>();
    }

    public void AdicionarFilme(Filme filme)
    {
        FilmeAtuado.Add(filme);
        if(!filme.Elenco.Contains(this)) filme.AdicionarElenco(this);
    }

    public void MostrarFilmesAtuados()
    {
        if (FilmeAtuado.Count == 0)
        {
            Console.WriteLine($"Nenhum filme encontrado na base pra {Nome}");
            return;
        }
        else
        {
            Console.WriteLine($"Filmes atuados por {Nome}");
            foreach (var filme in FilmeAtuado)
            {
                Console.WriteLine($"Filme: {filme.Titulo}");
            }
        }
    }
}