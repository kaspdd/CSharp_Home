using System.Text.Json.Serialization;

namespace TrappersBR_API.Modelos;

internal class Musica
{
    //a propriedade JsonProperTyName serve para linkar a propridade da classe com o campo dentro do arquivo json,
    //nesse caso abaixo foi a Propriedade 'Musica' da classe com o campo 'song' do json
    [JsonPropertyName("song")]
    public string Nome { get; set; }

    [JsonPropertyName("artist")]
    public string Artista { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duracao { get; set; }

    [JsonPropertyName("genre")]
    public string Genero { get; set; }


    public void ExibirDetalhesDaMusica()
    {
        Console.WriteLine($"Artista {Artista}\nNome da musica: {Nome}\nDuracao em segundos {Duracao}\nGenero musical: {Genero}");
        
    }
}