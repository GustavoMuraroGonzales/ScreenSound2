class Musica
{
    public string Nome {  get; set; }   
    public string Artista {  get; set; }    
    public int Duracao { get; set; }
    public bool Disponivel { get; set; }

    public string DescricaoResumida => $"A Música {Nome} pertence a: {Artista}";   
   



    public void ExibirFichaTecnica()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel == true)
        {
            Console.WriteLine($"A música {Nome} está disponivel em seu plano!");
        }
        else
        {
            Console.WriteLine($"A música {Nome} não está disponivel em seu plano!");
        }
    }

}