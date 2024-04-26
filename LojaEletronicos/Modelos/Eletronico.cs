namespace LojaEletronicos.Modelos;

internal class Eletronico
{
    public virtual void Exibir()
    {
        Console.WriteLine($"Segue as informacoes do produto:");
    }

    public virtual void Venda(int quantidade)
    {
        Console.WriteLine($"Digite quantos produtos deseja comprar:");
        quantidade = int.Parse(Console.ReadLine()!);
    }

    public virtual void ExibirAtualizado()
    {
        Console.WriteLine($"Segue as informacoes atualizadas do produto:");
    }
}