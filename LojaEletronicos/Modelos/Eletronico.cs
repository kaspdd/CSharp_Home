namespace LojaEletronicos.Modelos;

internal class Eletronico
{
    private List<Celular>  celulares = new List<Celular>();
    private List<Tablet> tablets = new List<Tablet>();
    private List<Notebook> notebooks = new List<Notebook>();
    public List<Celular> Celulares => celulares;
    public List<Tablet> Tablets => tablets;
    public List<Notebook> Notebooks => notebooks;
    public void ModeloTiuloMenu(string texto)
    {
        string traco = string.Empty.PadLeft(5,'-').PadRight(5,'-');
        Console.WriteLine($"{traco}{texto}{traco}");
    }

    public virtual void CadastrarCelular(Celular c)
    {
        celulares.Add(c);
    }
    public virtual void CadastrarTablet(Tablet t)
    {
        tablets.Add(t);
    }
    public virtual void CadastrarNotebook(Notebook n)
    {
        notebooks.Add(n);
    }
    public virtual void ExibirDetalhes()
    {
        ModeloTiuloMenu("Detalhes dos Produtos");
        
    }

    public virtual void Vender(int valor)
    {
        Console.WriteLine($"Vendido!!");
        
    }
}