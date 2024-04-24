namespace TrappersBR.Menus;
using TrappersBR.Modelos;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.WriteLine($"Saindo...");
    }
}