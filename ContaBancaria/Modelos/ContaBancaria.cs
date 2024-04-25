namespace ContaBancaria.Modelos;

internal class Conta
{   
    public double Saldo { get; set; }

    public string SacarOuDepositar()
    {
        Console.WriteLine($"Voce deseja sacar ou depositar?");
        Console.WriteLine($"Digite 1 para sacar\nDigite 2 para depositar: ");
        string opcao = Console.ReadLine()!;
        return opcao;
    }
    public void EscolhaContaCorrente()
    {
        
    }
    public void EscolhaContaPoupanca()
    {
        Console.WriteLine($"Voce escolheu a Conta poupanca!");
    }
    public virtual void Sacar(double valor)
    {
        Saldo -= valor;
        Console.WriteLine($"Foi sacado o valor de {valor}, atualmente a conta Poupanca tem {Saldo}");
    }

    public virtual void Depositar(double valor)
    {
        Saldo += valor;
        Console.WriteLine($"Foi depositado o valor de {valor}, atualmente a conta Poupanca tem {Saldo}");
    }
}