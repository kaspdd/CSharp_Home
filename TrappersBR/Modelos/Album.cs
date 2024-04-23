
namespace TrapperBR.Modelos;
internal class Album
{
    public Album(string nome, Genero genero)
    {
        Nome = nome;
        Genero = genero;
    }

    private List<Musica> musicas = new List<Musica>();
    //propriedades, pois tem get e set
    public string Nome { get;}
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);
    public Genero Genero { get; }
    

    //metodos
    //metodo para adicionar musicas na list<Musica>
    public void AdicionarMusica (Musica musica)
    {
        musicas.Add (musica);
    }

    // public void AdicionarGeneroAlbum (Genero genero)
    // {
    //     Genero = genero;
    // }

    public void ExibirMusicasDoAlbum ()
    {   
        Console.WriteLine ($"Segue as musicas do album: {Nome}: \n");

        foreach (var musica in musicas){
            Console.WriteLine ($"Musica: {musica.Nome}");
        }

        Console.WriteLine($"O genero do album é {Genero.Nome} e ele tem a duracao total é de {DuracaoTotal} segundos");
        
    }
}