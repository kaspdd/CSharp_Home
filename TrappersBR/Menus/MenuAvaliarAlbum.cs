using TrappersBR.Modelos;

namespace TrappersBR.Menus;

internal class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar Album");
        avaliandoNovamente:
        Console.Write("Digite o nome da banda que deseja avaliar: ");
        string nomeDaBanda = Console.ReadLine()!;
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            //buscando no dicionary pelo nome da banda
            Banda banda = bandasRegistradas[nomeDaBanda];
            Console.Write($"Digite o Titulo do album: ");
            string tituloAlbum = Console.ReadLine();
            //o codigo abaixo serve para pegar qualquer possicao (any) onde o nome do album seja igual (Equals) ao tituloAlbum
            if (banda.Albums.Any(a => a.Nome.Equals(tituloAlbum)))
            {
                //o codigo abaixo serve para pegar a primeira possicao (First) onde o nome do album seja igual (Equals) ao tituloAlbum
                Album album = banda.Albums.First(a => a.Nome.Equals(tituloAlbum));
                Console.Write($"Qual é a nota que o album {tituloAlbum} merece? ");
                Avaliacao nota = Avaliacao.Parse(Console.ReadLine());
                album.AdicionarNota(nota);
                Console.WriteLine($"A nota {nota.Nota} para o album {tituloAlbum} foi registrada com sucesso!!.");
            }
            else
            {
                Console.WriteLine($"O titulo do album {tituloAlbum} nao foi encontrado );");
            }
                Console.WriteLine("Aperte qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
        }
        else
        {
            Console.WriteLine($"A banda {nomeDaBanda} nao foi encontrado );");
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