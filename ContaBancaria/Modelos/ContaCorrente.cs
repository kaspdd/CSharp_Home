using System.Runtime.Intrinsics.Arm;

namespace ContaBancaria.Modelos;

internal class ContaCorrente : Conta
{
    
    public override void Sacar(double valor)
    {
        
        base.Sacar(valor);
    }

    public override void Depositar(double valor)
    {

        base.Depositar(valor);
    }    
}