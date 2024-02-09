class Musica
{
    public string nome;
    public string artista;
    public int duracao;
    public bool disponivel;

    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {nome}");
        Console.WriteLine($"Artista: {artista}");
        Console.WriteLine($"Duração: {duracao}");
        if (disponivel == true)
        {
            Console.WriteLine($"A música {nome} está disponivel em seu plano!");
        }
        else
        {
            Console.WriteLine($"A música {nome} não está disponivel em seu plano!");
        }
    }

    public void ExibirNomeArtista()
    {
        Console.WriteLine($"Nome/Artista: {nome} - {artista}");
    }

}