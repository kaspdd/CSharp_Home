using LojaEletronicos.Modelos;
using LojaEletronicos.Menus;


Eletronico e = new Eletronico();
Celular s10 = new Celular(1,"Galaxy S10",10);
Celular s20 = new Celular(2,"Galaxy S20",10);
// e.CadastrarCelular(s10);
// e.CadastrarCelular(s20);
Tablet tab8 = new Tablet(1,"Galaxy Tab 8",10);
Tablet tab9 = new Tablet(2,"Galaxy Tab 9",10);
// e.CadastrarTablet(tab8);
// e.CadastrarTablet(tab9);
Notebook book3602 = new Notebook(1,"Galaxy Book 360 2",10);
Notebook book3603 = new Notebook(2,"Galaxy Book 360 3",10);
// e.CadastrarNotebook(book3602);
// e.CadastrarNotebook(book3603);

Dictionary<string, Eletronico> eletronicos = new Dictionary<string, Eletronico>();
eletronicos.Add(s10.ModeloCelular, s10);
eletronicos.Add(s20.ModeloCelular,s20);
eletronicos.Add(tab8.ModeloTablet,tab8);
eletronicos.Add(tab9.ModeloTablet,tab9);
eletronicos.Add(book3602.ModeloNotebook,book3602);
eletronicos.Add(book3603.ModeloNotebook,book3603);

Dictionary<int, Menu> menus = new Dictionary<int, Menu>();
menus.Add(1, new MenuCadastrarCelular());
menus.Add(2, new MenuCadastrarTablet());
menus.Add(3, new MenuCadastrarTablet());
menus.Add(4, new MenuVender());
menus.Add(-1, new MenuSair());



void MenuPrincipal()
{
    e.ModeloTiuloMenu("Bem vindo a loja de eletronicos");
    voltandoAoTopo:
    Console.WriteLine($"Escolha uma opcao\n");
    Console.WriteLine($"Digite 1 para cadastrar um celular:");
    Console.WriteLine($"Digite 2 para cadastrar um tablet:");
    Console.WriteLine($"Digite 3 para cadastrar um notebook");
    Console.WriteLine($"Digite 4 para comprar um produto:");
    Console.WriteLine($"Digite 5 para listar os produtos:");

    
    Console.WriteLine($"Digite -1 para sair");
    string opcao = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcao);

    if(menus.ContainsKey(opcaoNumerica) && opcaoNumerica >= 0)
    {
        Menu m = menus[opcaoNumerica];
        m.Executar(eletronicos);
        MenuPrincipal();
    }
    else
    {
        Console.WriteLine($"Opcao invalida!");
        goto voltandoAoTopo;
        //Environment.Exit(0);
    }
    
}

MenuPrincipal();

