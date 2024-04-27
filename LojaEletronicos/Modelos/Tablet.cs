namespace LojaEletronicos.Modelos;

internal class Tablet : Eletronico
{
    public Tablet(int id, string modelo, int quantidade)
    {
        IdTablet = id;
        ModeloTablet = modelo;
        QuantidadeTablet = quantidade;
    }
    public int IdTablet { get; set; }
    public string ModeloTablet { get; set; }
    public int QuantidadeTablet { get; set; }
    public string ResumoTablet => $"Id: {IdTablet} Modelo: {ModeloTablet} Quantidade: {QuantidadeTablet}";

    public override void ExibirDetalhes()
    {
        base.ExibirDetalhes();
        ModeloTiuloMenu("Tablets");
        foreach(var t in Tablets)
        {
            Console.WriteLine(ResumoTablet);
        }
    }

    public override void Vender(int valor)
    {
        QuantidadeTablet =- valor;
        base.Vender(valor);
    }
    
}