using ScreenSound2;

Musica musica1 = new()
{
    Nome = "Roxane",
    Artista = "The Police",
    Duracao = 273,
    Disponivel = true
};
Console.WriteLine(musica1.Disponivel);


Musica musica2 = new()
{
    Nome = "Vertigo",
    Artista = "U2",
    Duracao = 367,
    Disponivel = false
};
Console.WriteLine(musica2.Disponivel);


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

