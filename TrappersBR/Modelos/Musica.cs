using System.Reflection.Metadata;
namespace TrapperBR.Modelos;
internal class Musica
{
    //metodod construtor
    public Musica(string nome, int duracao, Banda artista, Genero genero)
    {
        Nome = nome;
        Duracao = duracao;
        Artista = artista;
        Genero = genero;
    }
    //
    public string Nome { get;}
    public Banda Artista {get; }
    public int Duracao { get; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; }
    public string DescricaoResumida =>
    $"A musica {Nome} do genero {Genero.Nome} pertence ao artista {Artista}";
        
    


    //metodos
    // public void AdicionarGeneroDaMusica(Genero genero)
    // {
    //    Genero = genero;
    // }
    public void ExibirFichaTecnicaDaMusica()
    {
        Console.WriteLine($"Musicas:");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artista {Artista.Nome}");
        Console.WriteLine($"Genero: {Genero.Nome}");
        Console.WriteLine($"Duracao: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponivel!");
        }
        else
        {
            Console.WriteLine("Indisponivel!"); 
        }
        
    }


}





