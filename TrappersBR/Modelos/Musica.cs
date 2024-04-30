using System.Reflection.Metadata;
namespace TrappersBR.Modelos;
internal class Musica : IAvaliavel
{
    //metodod construtor
    public Musica(string nome, int duracao, Banda artista, Genero genero)
    {
        Nome = nome;
        Duracao = duracao;
        Artista = artista;
        Genero = genero;
    }
    private List<Avaliacao> notas = new();
    //
    public string Nome { get;}
    public Banda Artista {get; }
    public int Duracao { get; }
    public bool Disponivel { get; set; }
    public Genero Genero { get; }
    public string DescricaoResumida =>
    $"A musica {Nome} do genero {Genero.Nome} pertence ao artista {Artista}";
    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(m => m.Nota);
        }
    }
    
    //metodos
    // public void AdicionarGeneroDaMusica(Genero genero)
    // {
    //    Genero = genero;
    // }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
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





