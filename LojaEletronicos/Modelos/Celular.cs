namespace LojaEletronicos.Modelos;

internal class Celular : Eletronico
{
    public Celular(int id,string nome, int quantidade)
    {
        IdCelular = id;
        NomeCelular = nome;
        QuantidadeCelular = quantidade;

    }
    public int IdCelular { get; set; }
    public string NomeCelular { get; set;}
    public int QuantidadeCelular { get; set; }
    public string ResumoCelular => $"Id: {IdCelular}\nNome: {NomeCelular}\nQuantidade: {QuantidadeCelular}";
    public override void Exibir()
    {
        base.Exibir();
        Console.WriteLine($"Informacoes do Celular:\n");
        Console.WriteLine(ResumoCelular);
    }

    public override void Venda(int quantidade)
    {
        base.Venda(quantidade);
        Console.WriteLine($"Foi comprado o total de {quantidade}!");
        quantidade =- QuantidadeCelular;
        Console.WriteLine($"Quantidade atualizada {quantidade}!");
        
        
    }
    public override void ExibirAtualizado()
    {
        base.ExibirAtualizado();
        Console.WriteLine(ResumoCelular);
    }
}