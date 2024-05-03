namespace Atividade_Json.Modelos;
using System.Text.Json;
internal class Usuario
{
    public Usuario(string nome, int idade, string email)
    {
        Nome = nome;
        Idade = idade;
        Email = email;
    }
    public string Nome {get; }
    public int Idade {get; }
    public string Email {get;}

    public void GerarArquivoJson(string nomeArquivo)
    {
        string json = JsonSerializer.Serialize(new 
        {
            nome = Nome,
            idade = Idade,
            email = Email
        });
        string nomeDoArquivo = $"Usuarios cadastrados - {nomeArquivo}.json";
        File.WriteAllText(nomeDoArquivo, json);
        Console.WriteLine($"O arquivo Json Foi criado com sucesso!! {Path.GetFullPath(nomeDoArquivo)}"); 
    }
}