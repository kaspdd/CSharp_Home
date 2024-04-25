namespace ContaBancaria.Modelos;

internal class ContaPoupanca : Conta
{
    
    public override void Sacar(double valor)
    {
        base.Sacar(valor);
    }

    public override void Depositar(double valor)
    {
        EscolhaContaPoupanca();
        base.Depositar(valor);
    }    
}