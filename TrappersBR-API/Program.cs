using System.Runtime.Intrinsics.Arm;
using System.Text.Json;
using TrappersBR_API.Modelos;
using TrappersBR_API.Filtros;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        //Console.WriteLine($"{resposta}");
        //a linha abaixo esta Deserializando o arquivo.json que contem as musicas, e colocando dentro de uma lista do tipo Musica (classe) 
        //tudo isso esta sendo armazenado na variavel var
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta);
        Console.WriteLine($"{musicas.Count} musicas");

        //chamando a funcao usando o linq para tal ato.

        //exivindo todos os generos musicais
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);

        //exibindo todos os artista pelo nome
        //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);

        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "R&B");

        //LinqFilter.FiltrarMusicasDeUmArtista(musicas,  "Chris Brown");

        // var musicasPreferidasDoCarlos = new MusicasPreferidas("Carlos");
        // musicasPreferidasDoCarlos.AdicionarMusicasFavoritas(musicas[1]);
        // musicasPreferidasDoCarlos.AdicionarMusicasFavoritas(musicas[30]);
        // musicasPreferidasDoCarlos.AdicionarMusicasFavoritas(musicas[100]);
        // musicasPreferidasDoCarlos.AdicionarMusicasFavoritas(musicas[1502]);
        // musicasPreferidasDoCarlos.AdicionarMusicasFavoritas(musicas[1993]);
        
        // musicasPreferidasDoCarlos.ExibirMusicasFavoritas();

        var musicasPreferidasDaJuju = new MusicasPreferidas("Juju");
        musicasPreferidasDaJuju.AdicionarMusicasFavoritas(musicas[5]);
        musicasPreferidasDaJuju.AdicionarMusicasFavoritas(musicas[37]);
        musicasPreferidasDaJuju.AdicionarMusicasFavoritas(musicas[200]);
        musicasPreferidasDaJuju.AdicionarMusicasFavoritas(musicas[1610]);
        musicasPreferidasDaJuju.AdicionarMusicasFavoritas(musicas[1995]);
        
        musicasPreferidasDaJuju.ExibirMusicasFavoritas();

        musicasPreferidasDaJuju.GerarArquivoJson();
        
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
