namespace TrappersBR.Menus;
using TrappersBR.Modelos;

internal class Menu
{
    //funcao para colocar a quantidade de asterisco de acordo com o tamanho da string titulo.
    public void ExibirTituloDaOpcao(string titulo)
    {
        //int quantidadeDeLetras = titulo.Length;
        //o PadLeft é uma funcao que serve para colocar o caractere definido a esqueda, no caso foi o '-'
        string traco = string.Empty.PadRight(5, '-').PadLeft(5, '-');
        Console.WriteLine(traco + titulo + traco);
    }

    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
    }
}