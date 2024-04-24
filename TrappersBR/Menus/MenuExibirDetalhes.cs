using TrappersBR.Modelos;

namespace TrappersBR.Menus;

internal class MenuExibirDetalhes : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
    mediaNovamente:
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Media das aviliacoes dos artistas");
        Console.Write("Digite o nome do artista que deseja verificar a media das avaliacoes: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.WriteLine($"A media das avaliacoes da banda {nomeDaBanda} é: {banda.Media}");
        }
        else
        {
            Console.WriteLine($"O artista {nomeDaBanda} nao foi encontrado );");
        }
        Console.WriteLine("Deseja realizar uma nova avaliacao? \nDigite 1 para (SIM)\nDigite 2 ou qualquer outra tecla para (NAO): ");
        string opcaoAvaliacao = Console.ReadLine()!;
        switch (opcaoAvaliacao)
        {
            case "1":
                Console.Clear();
                goto mediaNovamente;
            default:
                Console.WriteLine("Aguarde 2 segundos para ser direcionado ao menu...");
                //A funcao Thread.Sleep(2000) faz com que o programa fique 2000 milesegundos parado antes da proxima acao.
                Thread.Sleep(2000);
                Console.Clear();
                //ExibirOpcoesDoMenu();
                break;
        }
    }
}