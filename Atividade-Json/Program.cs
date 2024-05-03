using System.Text.Json;
using Atividade_Json.Modelos;

try
{
    var registrando = new Usuario("Carlos",10,"carlos@gmail.com");

    registrando.GerarArquivoJson("Usuarios Registrados");
}
catch (Exception ex)
{
    Console.WriteLine($"A execucao apresentou erro: {ex.Message}");
    
}
