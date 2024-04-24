namespace TrappersBR.Menus;
using TrappersBR.Modelos;
internal class MenuAvaliarBanda : Menu
{

    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
    //digite qual artista deseja avaliar
    //verificar se a banda existe no dicionario, ai sim pode atribuir ao dicionario
    //senao, volta ao menu principal
    avaliandoNovamente:
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar Banda");
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;

        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            //buscando no dicionary pelo nome da banda
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write($"Qual é a nota que a banda {nomeDaBanda} merece? ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine());
            //atribuindo uma nota ao artista digitado no variavel nomeArtista.
            banda.AdicionarNota(nota);
            Console.WriteLine($"A nota {nota.Nota} para o banda {nomeDaBanda} foi registrada com sucesso!!.");
            Console.WriteLine("Aperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
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
                goto avaliandoNovamente;
            default:
                Console.WriteLine("Aguarde 2 segundos para ser direcionado ao menu...");
                //A funcao Thread.Sleep(2000) faz com que o programa fique 2000 milesegundos parado antes da proxima acao.
                Thread.Sleep(2000);
                Console.Clear();

                break;
        }
    }
}