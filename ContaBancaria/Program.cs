using ContaBancaria.Modelos;


void MenuPrincipal()
{
    Console.Clear();
    TituloModelo("Instituicao bancaria");
    Console.WriteLine($"Escolha uma opcao:");
    voltandoAoTopo:
    Console.WriteLine($"Digite 1 para cadastrar uma conta bancaria");
    string opcao = Console.ReadLine()!;
    switch (opcao)
    {
        case "1":
            CadastrarConta();
            break;
    }
}

void CadastrarConta()
{
    Console.Clear();
    TituloModelo("Cadastrando uma conta:");
    int id = 0;
    Console.Write($"Digite o nome do Titular:");
    string titular = Console.ReadLine()!;
    id += 1;
    Conta c = new Conta(id,titular);
}




void VoltandoAoMenu()
{
    Console.WriteLine($"Deseja voltar ao menu?");
    VoltandoAoTopo:
    Console.WriteLine($"Digite 1 para continuar\nDigite 2 para sair:");
    
    string opcao = Console.ReadLine()!;
    switch (opcao)
    {
        case "1":
            Console.WriteLine($"Voltando ao Menu em 2 segundos...");
            Thread.Sleep(2000);
            MenuPrincipal();
            break;
        case "2":
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine($"Opcao invalida! Por favor digite uma opcao valida:");
            goto VoltandoAoTopo;

    } 
}

void TituloModelo(string titulo)
{
    string traco = string.Empty.PadLeft(5,'-').PadRight(5,'-');
    Console.WriteLine($"{traco}{titulo}{traco}");
}