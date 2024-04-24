namespace TrappersBR.Menus;
using TrappersBR.Modelos;

internal class MenuMostrarBandasRegistradas : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
    base.Executar(bandasRegistradas);
    ExibirTituloDaOpcao("Exibindo Banda Registradas");
    // for (int i = 0; i< listaDasBandas.Count; i++)
    // {
    //     Console.WriteLine($"Artista: {listaDasBandas[i]}");
    // }
    
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Artista: {banda} ");
    }

    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu:");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Voltando...");
    Thread.Sleep(2000);
    }
}