namespace LojaEletronicos.Modelos;

internal class Notebook : Eletronico
{
    public Notebook(int id, string nome, int quantidade)
    {
        IdNotebook = id;
        NomeNotebook = nome;
        QuantidadeNotebook = quantidade;
    }
    public int IdNotebook { get; set; }
    public string NomeNotebook { get; set; }
    public int QuantidadeNotebook { get; set; }
    public string ResumoNotebook => $"Id: {IdNotebook}\nNome: {NomeNotebook}\nQuantidade: {QuantidadeNotebook}";
    public override void Exibir()
    {
        base.Exibir();
        Console.WriteLine($"Informacoes do Notebook:\n");
        Console.WriteLine(ResumoNotebook);
    }

    public override void Venda(int quantidade)
    {
        base.Venda(quantidade);
        Console.WriteLine($"Foi comprado o total de: {quantidade}!");
        quantidade =- QuantidadeNotebook;
        Console.WriteLine($"Quantidade atualizada para: {quantidade}!");
    }

    public override void ExibirAtualizado()
    {
        base.ExibirAtualizado();
        Console.WriteLine(ResumoNotebook);
    }
}