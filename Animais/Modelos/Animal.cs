namespace Animais.Modelos;

internal class Animal
{
    //public string Som { get; set; }

    public virtual void EmitirSom ()
    {
        Console.WriteLine($"Som do animal:");
        
    }
}