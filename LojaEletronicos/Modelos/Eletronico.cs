namespace LojaEletronicos.Modelos;
using LojaEletronicos.Menus;

internal class Eletronico
{
    private List<Eletronico> produtos = new List<Eletronico>();
    public void ModeloTiuloMenu(string texto)
    {
        string traco = string.Empty.PadLeft(5,'-').PadRight(5,'-');
        Console.WriteLine($"{traco}{texto}{traco}");
    }

    public void Cadastrar(Eletronico e)
    {
        produtos.Add(e);
    }

    // public virtual void CadastrarCelular(Celular c)
    // {
    //     celulares.Add(c);
    // }
    // public virtual void CadastrarTablet(Tablet t)
    // {
    //     tablets.Add(t);
    // }
    // public virtual void CadastrarNotebook(Notebook n)
    // {
    //     notebooks.Add(n);
    // }
    public void ExibirDetalhes()
    {
        ModeloTiuloMenu("Detalhes dos Produtos");
        foreach(var n in produtos)
        {  
            Console.WriteLine($"");
        }
    }
        

    public virtual void Vender(int valor)
    {
        Console.WriteLine($"Vendido!!");
        
    }
}