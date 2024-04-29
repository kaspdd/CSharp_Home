namespace LojaEletronicos.Menus;
using LojaEletronicos.Modelos;

internal class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Eletronico> eletronicos)
    {
        Console.WriteLine($"Saindo...");
        
    }
}