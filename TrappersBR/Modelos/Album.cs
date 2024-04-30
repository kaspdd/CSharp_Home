
namespace TrappersBR.Modelos;
internal class Album : IAvaliavel
{
    public Album(string nome, Genero genero)
    {
        Nome = nome;
        Genero = genero;
        ContadorDeAlbuns++;
    }

    private List<Musica> musicas = new List<Musica>();
    private List<Avaliacao> notas = new();
    public List<Musica> Musicas => musicas;
    //propriedades, pois tem get e set
    public string Nome { get; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public static int ContadorDeAlbuns = 0;
    public Genero Genero { get; }

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(m => m.Nota);
        }
    }
    //metodos
    //metodo para adicionar musicas na list<Musica>
    public void AdicionarMusica(Musica musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Segue as musicas do album: {Nome}: \n");

        foreach (var musica in musicas)
        {
            Console.WriteLine($"Musica: {musica.Nome}");
        }

        Console.WriteLine($"O genero do album é {Genero.Nome} e ele tem a duracao total é de {DuracaoTotal} segundos");

    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }
}