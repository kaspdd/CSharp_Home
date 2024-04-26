namespace Animais.Modelos;

internal class Gato : Animal
{
    public override void EmitirSom ()
    {
        base.EmitirSom ();
        Console.WriteLine($"O Gato faz Miau!");        
    }
}