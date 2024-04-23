
//o namespace aqui esta retratando o nome da pasta prinicipal que contem o projeto, seguido do nome da pasta que estao as classes modelo.
namespace TrapperBR.Modelos;

internal class Banda
{
    public Banda(string nome)
    {
        Nome = nome;
    }
    private List<Album> albums = new List<Album>();
    private List<Avaliacao> notas = new List<Avaliacao>();

    //para possibilitar que o parametro abaixo consiga utlizar o get(somente leitura) somente se o construtor estiver pedindo algo ou setando um valor direto no parametro.
    public string Nome { get; }
    //pegando a media das notas das bandas, porem com uma verificacao, pois se nao tiver notas na banda, ele retornara 0.
    public double Media 
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }
    //public List<Album> album => albums;
    

    //metodos
    public void AdicionarAlbum(Album album)
    {
        albums.Add(album);
    }

    public void AdicionarNota(Avaliacao nota)
    {
        notas.Add(nota);
    }

    public void ExibirDiscografia ()
    {
        Console.WriteLine($"Discografia do Artista {Nome}:");

        foreach(var album in albums)
        {
            Console.WriteLine ($"Album: {album.Nome}\nGenero do Album: {album.Genero}\n - (Duracao do Album: {album.DuracaoTotal} segundos.)");
        }
    }
}