namespace LojaEletronicos.Menus;
using LojaEletronicos.Modelos;

internal class Menu
{
    public void ModeloTiuloMenu(string texto)
    {
        string traco = string.Empty.PadLeft(5,'-').PadRight(5,'-');
        Console.WriteLine($"{traco}{texto}{traco}");
    }
    public virtual void Executar(Dictionary<int,Eletronico> eletronicos)
    {
        Console.Clear();
    }
}