using System.Text.Json.Serialization;
using System.Text.Json;

namespace TrappersBR_API.Modelos;

internal class MusicasPreferidas
{
    public MusicasPreferidas(string nome)
    {
        Nome = nome;
        ListaDeMusicasFavoritas = new List<Musica>();
    }
    
    public string Nome { get; set; }
    public List<Musica> ListaDeMusicasFavoritas { get; }

    public void AdicionarMusicasFavoritas(Musica musica)
    {
        ListaDeMusicasFavoritas.Add(musica);
    }

    public void ExibirMusicasFavoritas()
    {
        Console.WriteLine($"Essas sao as musicas favoritas -> {Nome}");
        foreach (var musica in ListaDeMusicasFavoritas)
        {
            Console.WriteLine($"- {musica.Nome} de {musica.Artista}");
        }
        Console.WriteLine($"");
        
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new 
        {
            nome = Nome,
            musicas = ListaDeMusicasFavoritas
        });
        string nomeDoArquivo = $"Musicas - favoritas - {Nome}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json Foi criado com sucesso!! {Path.GetFullPath(nomeDoArquivo)}");
        
    }
}