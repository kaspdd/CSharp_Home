using Animais.Modelos;

Dictionary<int, Animal> animais = new Dictionary<int, Animal>();
animais.Add(1, new Cachorro());
animais.Add(2, new Gato());
animais.Add(3, new Humano());

void MenuPrincipal()
{
    Console.Clear();
    ModeloTitulo("Bem vindo ao Sons dos animais");
voltandoAoTopo:
    Console.WriteLine($"Escolha uma opcao:");
    Console.WriteLine($"Digite 1 para emitir o som do cachorro\nDigite 2 para emitir o som do gato:\nDigite 3 para emitir o som do humano\nDigite 4 para sair..");
    string opcao = Console.ReadLine()!;
    int opcaoNumerica = int.Parse(opcao);

    if (animais.ContainsKey(opcaoNumerica))
    {
        Animal animalSelecionado = animais[opcaoNumerica];
        animalSelecionado.EmitirSom();
    }
    else if (opcaoNumerica == 4)
    {
        Console.WriteLine($"Saindo...");
        Environment.Exit(0);
    }
    else
    {
        Console.WriteLine($"Opcao invalida!");
        goto voltandoAoTopo;
    }

    MenuSair();
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
