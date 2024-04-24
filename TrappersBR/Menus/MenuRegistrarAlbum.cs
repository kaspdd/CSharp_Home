namespace TrappersBR.Menus;
using TrappersBR.Modelos;

internal class MenuRegistrarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Registrando Albuns");
    registrarALbumNovamente:
        Console.Write("Digite o nome da Banda para registrar um album:");
        string nomeDaBanda = Console.ReadLine();
        if (bandasRegistradas.ContainsKey(nomeDaBanda))
        {
            Console.Write($"Digite o Titulo do album: ");
            string nomeDoAlbum = Console.ReadLine();
            Console.Write("Digite o genero do album: ");
            string generoDoAlbum = Console.ReadLine();
            Genero genero = new Genero(generoDoAlbum);
            //atribuindo o nome da banda (que ja foi verificada acima que existe dentro do dicinary) a variavel banda do tipo Banda. 
            Banda banda = bandasRegistradas[nomeDaBanda];
            //Adicionando o nome do albume e o genero na classe banda atravez da funcao AdicionarAlbum.
            banda.AdicionarAlbum(new Album(nomeDoAlbum, genero));
            Console.WriteLine($"Album {nomeDoAlbum} e genero {generoDoAlbum} adicionado com sucesso na Banda {nomeDaBanda}!");
        }
        else
        {
            Console.WriteLine($"Banda Digitada nao encontrada );\nPor favor tentar novamente.");
            goto registrarALbumNovamente;
        }
        Console.WriteLine("Deseja registrar um novo Artista?\nDigite 1 para (SIM)\nDigite 2 ou qualquer outra tecla para (NAO)");
        string opcaoRegistrarAlbum = Console.ReadLine()!;
        switch (opcaoRegistrarAlbum)
        {
            case "1":
                Console.Clear();
                goto registrarALbumNovamente;
            default:
                Console.WriteLine("Aguarde 2 segundos para ser direcionado ao menu...");
                //A funcao Thread.Sleep(2000) faz com que o programa fique 2000 milesegundos parado antes da proxima acao.
                Thread.Sleep(2000);
                Console.Clear();
                
                break;
        }
    }
}