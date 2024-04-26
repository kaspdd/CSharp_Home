namespace Animais.Modelos;

internal class Humano : Animal
{
    public override void EmitirSom ()
    {
        base.EmitirSom ();
        Console.WriteLine($"O Humano faz Cade meu Dinheirooooooooo?");        
    }
}