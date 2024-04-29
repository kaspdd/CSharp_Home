namespace LojaEletronicos.Modelos;

internal class Notebook : Eletronico
{
    public Notebook(int id, string modelo, int quantidade)
    {
        IdNotebook = id;
        ModeloNotebook = modelo;
        QuantidadeNotebook = quantidade;
    }
    public int IdNotebook { get; set; }
    public string ModeloNotebook { get; set; }
    public int QuantidadeNotebook { get; set; }
    public string ResumoNotebook => $"Id: {IdNotebook} Modelo: {ModeloNotebook} Quantidade: {QuantidadeNotebook}";

    // public override void ExibirDetalhes()
    // {
    //     base.ExibirDetalhes();
    //     ModeloTiuloMenu("Notebooks");
    //     foreach(var n in Notebooks)
    //     {
    //         Console.WriteLine(ResumoNotebook);       
    //     }
    // }

    public override void Vender(int valor)
    {
        QuantidadeNotebook =- valor;
        base.Vender(valor);
    }
    
}