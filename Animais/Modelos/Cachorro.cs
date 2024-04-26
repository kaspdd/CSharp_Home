namespace Animais.Modelos;

internal class Cachorro : Animal
{
    public override void EmitirSom ()
    {
        base.EmitirSom ();
        
        Console.WriteLine($"O cachorro faz AuAu!");        
    }
}