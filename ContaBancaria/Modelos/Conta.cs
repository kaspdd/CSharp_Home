namespace ContaBancaria.Modelos;

internal class Conta
{
    public Conta(int idConta, string titular)
    {
        IdConta = idConta;
        Titular = titular;
    }
    public int IdConta { get; set; }
    public string Titular { get; set; }
    public double Saldo = 0;




}