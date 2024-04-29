namespace LojaEletronicos.Menus;

using System.Threading.Channels;
using LojaEletronicos.Modelos;

internal class MenuVender : Menu
{
    public override void Executar(Dictionary<string, Eletronico> eletronicos)
    {
        base.Executar(eletronicos);
        Eletronico e = new Eletronico() ;
        e.ModeloTiuloMenu("Comprando");
        Console.WriteLine($"Segue a tabela de produtos cadastrados:");
        e.ExibirDetalhes();
        //
    }
}