using System.Linq;
using TrappersBR_API.Modelos;

namespace TrappersBR_API.Filtros;

internal class LinqOrder
{
    public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
    {
        //nesta linha abaixo ordenando as musicas em ordem crescente pelo nome do artista, depois foi feita a selecao pelo nome do artista da musica.
        var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
        Console.WriteLine($"Lista de artistas ordernados");
        
        foreach (var artista in artistasOrdenados)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}