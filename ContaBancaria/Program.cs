using ContaBancaria.Modelos;

Dictionary<int, Conta> tiposDeConta = new Dictionary<int, Conta>();

tiposDeConta.Add(1, new ContaCorrente());
tiposDeConta.Add(2, new ContaPoupanca());

string opcaoOperacao = "";

Console.WriteLine($"Bem vindo ao banco!");
voltandoAoTopo:
Console.WriteLine($"Escolha uma opcao:");
Console.WriteLine($"Digite 1 para acessar a conta corrente:\nDigite 2 para acessar a conta poupanca: ");
string opcao = Console.ReadLine()!;
int opcaoNumerica = int.Parse(opcao);
if (tiposDeConta.ContainsKey(opcaoNumerica))
{
    if (opcaoNumerica == 1)
    {
        Conta contaSelecionada = tiposDeConta[opcaoNumerica];
        Console.WriteLine($"Voce escolheu a Conta corrente!");
        opcaoOperacao = contaSelecionada.SacarOuDepositar();
        switch (opcaoOperacao)
        {
            case "1":
                Console.WriteLine($"Digite o valor que deseja sacar:");
                double valorS = double.Parse(Console.ReadLine()!);
                contaSelecionada.Sacar(valorS);
                break;
            case "2":
                Console.WriteLine($"Digite o valor que deseja depositar:");
                double valorD = double.Parse(Console.ReadLine()!);
                contaSelecionada.Depositar(valorD);
                break;
        }
    }
    else if(opcaoNumerica == 2)
    {
        Conta contaSelecionada = tiposDeConta[opcaoNumerica];
        Console.WriteLine($"Voce escolheu a Conta poupanca!");
        opcaoOperacao = contaSelecionada.SacarOuDepositar();
        switch (opcaoOperacao)
        {
            case "1":
                Console.WriteLine($"Digite o valor que deseja sacar:");
                double valorS = double.Parse(Console.ReadLine()!);
                contaSelecionada.Sacar(valorS);
                break;
            case "2":
                Console.WriteLine($"Digite o valor que deseja depositar:");
                double valorD = double.Parse(Console.ReadLine()!);
                contaSelecionada.Depositar(valorD);
                break;
        }
        
    }
    else
    {
        Console.WriteLine($"Opcao invalida!");
        goto voltandoAoTopo;
        
    }
    
    

}


