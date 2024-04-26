namespace LojaEletronicos.Modelos;

internal class Tablet : Eletronico
{
    public Tablet(int id, string nome, int quantidade)
    {
        IdTablet = id;
        NomeTablet = nome;
        QuantidadeTablet = quantidade;
    }
    public int IdTablet { get; set; }
    public int QuantidadeTablet { get; set; }
    public string NomeTablet { get; set; }
    public string ResumoTablet => $"Id: {IdTablet}\nNome: {NomeTablet}\nQuantidade: {QuantidadeTablet}";
    public override void Exibir()
    {
        base.Exibir();
        Console.WriteLine($"Informacoes do Tablet:\n");
        Console.WriteLine(ResumoTablet);
    }

    public override void Venda(int quantidade)
    {
        base.Venda(quantidade);
        Console.WriteLine($"Foi comprado o total de: {quantidade}!");
        quantidade =- QuantidadeTablet;
        Console.WriteLine($"Quantidade atualizada para: {quantidade}!");
    }

    public override void ExibirAtualizado()
    {
        base.ExibirAtualizado();
        Console.WriteLine(ResumoTablet);
    }
}