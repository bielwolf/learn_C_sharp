
class Musica
{
    public Musica(Banda artista, string nome)
    {
        Artista = artista;
        Nome = nome;
    }
    public string Nome { get; }
    public Banda Artista { get; }
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; set; }
    public string DescricaoResumida => $"A música {Nome} pertecente à banda {Artista}";

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista.Nome}");
        Console.WriteLine($"Duracao: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine($"Disponivel no plano.");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus+");
        }
    }
    public void ExibirNomeArtista()
    {
        Console.WriteLine($"Nome/Artista: {Nome} - {Artista}");
    }
}
