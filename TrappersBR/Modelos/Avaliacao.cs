namespace TrapperBR.Modelos;

internal class Avaliacao
{
    public Avaliacao (int nota)
    {
        Nota = nota;
    }
    public int Nota {get;}

    //usando o metodo static para que nao precise instaciar a avalicao, ele ja esta sendo instaciado no retorno com: new Avaliacao (nota).
    public static Avaliacao Parse (string texto)
    {
        int nota = int.Parse(texto);
        if (nota < 0 )
        {
            return new Avaliacao (0);
        }
        else if (nota > 10)
        {
            return new Avaliacao (10);
        }
        return new Avaliacao (nota);
    }
    
}