namespace TrappersBR.Menus;
using TrappersBR.Modelos;

internal class MenuRegistrarBandas : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
    registrarNovamente:
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registrar Bandas");
        Console.Write("Digite o nome do Artista: ");
        string nomeDaBanda = Console.ReadLine()!;
        Console.WriteLine($"\nO Artista {nomeDaBanda} foi Registrado com sucesso!!\n");
        Banda banda = new Banda(nomeDaBanda);
        bandasRegistradas.Add(nomeDaBanda, banda);
        Console.WriteLine("Deseja registrar um novo Artista?\nDigite 1 para (SIM)\nDigite 2 ou qualquer outra tecla para (NAO)");
        string opcaoRegistrarBandas = Console.ReadLine()!;
        switch (opcaoRegistrarBandas)
        {
            case "1":
                Console.Clear();
                goto registrarNovamente;
            default:
                Console.WriteLine("Aguarde 2 segundos para ser direcionado ao menu...");
                //A funcao Thread.Sleep(2000) faz com que o programa fique 2000 milesegundos parado antes da proxima acao.
                Thread.Sleep(2000);
                Console.Clear();
                break;
        }
    }
}