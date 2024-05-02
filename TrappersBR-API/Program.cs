using System.Runtime.Intrinsics.Arm;
using System.Text.Json;
using TrappersBR_API.Modelos;

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

        musicas[0].ExibirDetalhesDaMusica();
        
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema: {ex.Message}");
    }
}
