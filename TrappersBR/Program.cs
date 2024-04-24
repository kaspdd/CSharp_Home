// See https://aka.ms/new-console-template for more information

using System.Runtime.CompilerServices;
using TrappersBR.Modelos;
using TrappersBR.Menus;
 
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

Dictionary<int, Menu> opcoes = new Dictionary<int, Menu>();
opcoes.Add(1, new MenuRegistrarBandas());
opcoes.Add(2, new MenuRegistrarAlbum());
opcoes.Add(3, new MenuMostrarBandasRegistradas());
opcoes.Add(4, new MenuAvaliarBanda());
opcoes.Add(5, new MenuExibirDetalhes());
opcoes.Add(6, new MenuSair());

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

void ExibirOpcoesDoMenu()
{
    opcaoInvalida:
    ExibirLogo();
    Console.WriteLine("Escolha uma opcao no nosso menu: \n");
    Console.WriteLine("Digite 1 - Para cadastrar uma banda");
    Console.WriteLine("Digite 2 - para cadastrar um album");
    Console.WriteLine("Digite 3 - Para listar as bandas");
    Console.WriteLine("Digite 4 - Para avaliar um artista");
    Console.WriteLine("Digite 5 - Para exibir a media de uma banda");
    Console.WriteLine("Digite 6 - Para sair: ");
    string opcaoEscolhida = Console.ReadLine();
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);
    if (opcoes.ContainsKey(opcaoEscolhidaNumerica))
    {
        Menu menuASerExibido = opcoes[opcaoEscolhidaNumerica];
        menuASerExibido.Executar(bandasRegistradas);
        //if para voltar ao menu principal, ou seja, qualquer valor que seja fora do range (1,7) ele vai voltar para o menu
        if(opcaoEscolhidaNumerica > 0 &&  opcaoEscolhidaNumerica < 6)
        {
            Console.WriteLine($"Opcao invalida!");
            goto opcaoInvalida;
        }
    }
    else
    {
        Console.WriteLine($"Opcao invalida!");
        goto opcaoInvalida;
        
    }
    
}
ExibirOpcoesDoMenu();



