namespace LojaEletronicos.Modelos;

internal class Celular : Eletronico
{
    public Celular(int id, string modelo, int quantidade)
    {
        IdCelular = id;
        ModeloCelular = modelo;
        QuantidadeCelular = quantidade;
    }
    public int IdCelular { get; set; }
    public string ModeloCelular { get; set; }
    public int QuantidadeCelular { get; set; }
    public string ResumoCelular => $"Id: {IdCelular} Modelo: {ModeloCelular} Quantidade: {QuantidadeCelular}";

    public override void ExibirDetalhes()
    {
        base.ExibirDetalhes();
        ModeloTiuloMenu("Celulares");
        foreach(var c in Celulares)
        {
            Console.WriteLine(ResumoCelular);
            
        }
    }

    public override void Vender(int valor)
    {
        QuantidadeCelular =- valor;
        base.Vender(valor);
    }
}

