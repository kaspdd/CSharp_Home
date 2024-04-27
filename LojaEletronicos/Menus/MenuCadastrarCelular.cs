namespace LojaEletronicos.Menus;
using LojaEletronicos.Modelos;

internal class MenuCadastrarCelular : Menu
{
    public virtual void Executar(Dictionary<int,Eletronico> eletronicos)
    {
        base.Executar(eletronicos);
        Eletronico e = new Eletronico();
        ModeloTiuloMenu("Cadastrar Celular");
        int contC = e.Celulares.Count;
        int contE = eletronicos.Keys.Count;
        int i = 0;
        while (i==0)
        Console.Write($"Digite o modelo do celular: ");
        string modelo = Console.ReadLine()!;
        Console.Write($"Digite a quantidade que deseja cadastrar: ");
        int quantidade = int.Parse(Console.ReadLine()!);
        contC++;
        contE++;
        Celular c = new Celular(contC,modelo,quantidade );
        if(eletronicos.ContainsKey() && eletronicos.)
        {

        }
    }
}