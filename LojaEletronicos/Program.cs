using LojaEletronicos.Modelos;

Dictionary<int, Eletronico> eletronicos = new Dictionary<int, Eletronico>();
eletronicos.Add(1, new Celular(1,"Galazy S10",10));
eletronicos.Add(2, new Celular(2,"Galaxy M31",10));
eletronicos.Add(3, new Tablet(1,"Galaxy Tab 8",10));
eletronicos.Add(4, new Tablet(2,"Galaxy Tab 9",10));
eletronicos.Add(5, new Notebook(1,"Galaxy Book2 360",10));
eletronicos.Add(6, new Notebook(2,"Galaxy Book3 360",10));


void MenuPrincipal()
{
    Console.Clear();
    ModeloTitulo("Bem vindo ao Sons dos animais");
voltandoAoTopo:
    Console.WriteLine($"Escolha uma opcao:");
    Console.WriteLine($"Digite 1 para emitir o som do cachorro\nDigite 2 para emitir o som do gato:\nDigite 3 para emitir o som do humano\nDigite 4 para sair..");
    string opcao = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcao);
    if (eletronicos.ContainsKey(opcaoNumerica))
    {
        if(opcaoNumerica == 1)
        {

        }
        

        
    }
}

void ModeloTitulo(string texto)
{
    string traco = string.Empty.PadLeft(5, '-').PadRight(5, '-');
    Console.WriteLine(traco + texto + traco);
}
void MenuSair()
{
    Console.WriteLine($"\n\nDeseja voltar ao menu?");
    VoltandoAoTopo:
    Console.WriteLine($"Digite 1 para (sim)\nDigite 2 para (sair)");
    string opcao = Console.ReadLine()!;
    switch (opcao)
    {
        case "1":
            Console.WriteLine($"Voltando ao menu em 2 segundos...");
            Thread.Sleep(2000);
            MenuPrincipal();
            break;
        case "2":
            Console.WriteLine($"Saindo...");
            break;
        default:
            Console.WriteLine("Opcao invalida!");
            goto VoltandoAoTopo;
    }
}
MenuPrincipal();

