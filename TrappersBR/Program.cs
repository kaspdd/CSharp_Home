// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using TrapperBR.Modelos;

Banda ricardoMoveis = new Banda("Ricardo Moveis");
ricardoMoveis.AdicionarNota(new Avaliacao(10));
ricardoMoveis.AdicionarNota(new Avaliacao(9));
ricardoMoveis.AdicionarNota(new Avaliacao(8));
Banda chrisBrown = new Banda("Chris Brown");
chrisBrown.AdicionarNota(new Avaliacao(10));
chrisBrown.AdicionarNota(new Avaliacao(9));
chrisBrown.AdicionarNota(new Avaliacao(10));


Dictionary<string, Banda> bandasRegistradas = new Dictionary<string, Banda>();
bandasRegistradas.Add(ricardoMoveis.Nome, ricardoMoveis);
bandasRegistradas.Add(chrisBrown.Nome, chrisBrown);

const string mensagemDeBoasVindas = "Bem vindo a Galery dos Trappers Br!\n";

static void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░░█████╗░██╗░░░░░███████╗██████╗░██╗░░░██╗  ████████╗██████╗░░█████╗░██████╗░██████╗░███████╗██████╗░░██████╗
██╔════╝░██╔══██╗██║░░░░░██╔════╝██╔══██╗╚██╗░██╔╝  ╚══██╔══╝██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝██╔══██╗██╔════╝
██║░░██╗░███████║██║░░░░░█████╗░░██████╔╝░╚████╔╝░  ░░░██║░░░██████╔╝███████║██████╔╝██████╔╝█████╗░░██████╔╝╚█████╗░
██║░░╚██╗██╔══██║██║░░░░░██╔══╝░░██╔══██╗░░╚██╔╝░░  ░░░██║░░░██╔══██╗██╔══██║██╔═══╝░██╔═══╝░██╔══╝░░██╔══██╗░╚═══██╗
╚██████╔╝██║░░██║███████╗███████╗██║░░██║░░░██║░░░  ░░░██║░░░██║░░██║██║░░██║██║░░░░░██║░░░░░███████╗██║░░██║██████╔╝
░╚═════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚═╝░░░╚═╝░░░  ░░░╚═╝░░░╚═╝░░╚═╝╚═╝░░╚═╝╚═╝░░░░░╚═╝░░░░░╚══════╝╚═╝░░╚═╝╚═════╝░

██████╗░██████╗░
██╔══██╗██╔══██╗
██████╦╝██████╔╝
██╔══██╗██╔══██╗
██████╦╝██║░░██║
╚═════╝░╚═╝░░╚═╝
            ");
    Console.WriteLine(mensagemDeBoasVindas);

}
//Funcoes
void RegistrarBandas()
{
    registrarNovamente:
    Console.Clear();
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
            ExibirOpcoesDoMenu();
            break;
    }
    
}

void RegistrarAlbum()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registrando Albuns");
    registrarALbumNovamente:
    Console.Write("Digite o nome da Banda para registrar um album:");
    string nomeDaBanda = Console.ReadLine();
    if(bandasRegistradas.ContainsKey(nomeDaBanda))
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
            ExibirOpcoesDoMenu();
            break;
    }
}

void MostrarBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo Banda Registradas");
    // for (int i = 0; i< listaDasBandas.Count; i++)
    // {
    //     Console.WriteLine($"Artista: {listaDasBandas[i]}");
    // }
    
    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Artista: {banda} ");
    }

    Console.WriteLine("\nDigite qualquer tecla para voltar ao menu:");
    Console.ReadKey();
    Console.Clear();
    Console.WriteLine("Voltando...");
    Thread.Sleep(2000);
    ExibirOpcoesDoMenu();
}

// void ExibirDetalhesDaBanda()
// {
//     ExibirTituloDaOpcao("Exibindo detalhes da Banda");
//     Console.Write("Digite o nome da Banda que deseja conhecer melhor: ");
//     string nomeDaBanda = Console.ReadLine()!; 
//     if(bandasRegistradas.ContainsKey(nomeDaBanda))
//     {
//         Banda banda = bandasRegistradas[nomeDaBanda];
//         Console.WriteLine($"\nA Media de avaliacoes da banda {nomeDaBanda} é: {banda.Media}.");
//          Console.WriteLine("Aperte qualquer tecla para continuar...");
//         Console.ReadKey();
//         Console.Clear();
//         ExibirOpcoesDoMenu();
//     }
// }

void AvaliarBanda()
{
    //digite qual artista deseja avaliar
    //verificar se a banda existe no dicionario, ai sim pode atribuir ao dicionario
    //senao, volta ao menu principal
    avaliandoNovamente:
    Console.Clear();
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
            ExibirOpcoesDoMenu();
            break;
    }
    
}

void MediaAvaliacaoBandas()
{
    mediaNovamente:
    Console.Clear();
    ExibirTituloDaOpcao("Media das aviliacoes dos artistas");
    Console.Write("Digite o nome do artista que deseja verificar a media das avaliacoes: ");
    string nomeDaBanda = Console.ReadLine()!;

    if(bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Banda banda = bandasRegistradas[nomeDaBanda];
        Console.WriteLine($"A mediaDasNotas das avaliacoes do artista {nomeDaBanda} é: {banda.Media}");
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
            ExibirOpcoesDoMenu();
            break;
    }
}


//funcao para colocar a quantidade de asterisco de acordo com o tamanho da string titulo.
void ExibirTituloDaOpcao(string titulo)
{
    //int quantidadeDeLetras = titulo.Length;
    //o PadLeft é uma funcao que serve para colocar o caractere definido a esqueda, no caso foi o '-'
    string traco = string.Empty.PadRight(5,'-').PadLeft(5,'-');
    Console.WriteLine(traco+titulo+traco);
}

void ExibirOpcoesDoMenu()
{
    opcaoInvalida:
    ExibirLogo();
    Console.WriteLine("Escolha uma opcao no nosso menu: \n");
    Console.WriteLine("Digite 1 - Para cadastrar um Artista");
    Console.WriteLine("Digite 2 - para cadastrar um album");
    Console.WriteLine("Digite 3 - Para listar os Artitas");
    Console.WriteLine("Digite 4 - Para avaliar um artista");
    Console.WriteLine("Digite 5 - Para exibir a media de um Artista");
    Console.WriteLine("Digite 6 - Para sair: ");
    string opcaoEscolhida = Console.ReadLine()!;

    switch (opcaoEscolhida)
    {
        case "1":
            RegistrarBandas();
            //Console.WriteLine($"Voce escolheu a opcao {opcaoEscolhida} ");
            break;
        case "2":
            RegistrarAlbum();
            //Console.WriteLine($"Voce escolheu a opcao {opcaoEscolhida} ");
            break;
        case "3":
            MostrarBandasRegistradas();
            break;
        case "4":
            AvaliarBanda();
            break;
        case "5":
            MediaAvaliacaoBandas();
            
            break;
        case "6":
            Console.WriteLine("Flwwwww...");
            break;
        default:
            Console.WriteLine($"Voce escolheu uma opcao invalida ); ");
            Console.WriteLine("Tente Novamente\n");
            goto opcaoInvalida;
    }

}




ExibirOpcoesDoMenu();

