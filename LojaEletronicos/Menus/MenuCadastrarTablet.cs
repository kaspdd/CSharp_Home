namespace LojaEletronicos.Menus;
using LojaEletronicos.Modelos;

internal class MenuCadastrarTablet : Menu
{
    public override void Executar(Dictionary<string, Eletronico> eletronicos)
    {
        base.Executar(eletronicos);
        Eletronico e = new Eletronico();
        ModeloTiuloMenu("Cadastrar Celular");
        int contT = 2;
        int contE = eletronicos.Keys.Count;
        int i = 0;

        while (i == 0)
        {
            Console.Write($"Digite o modelo do tablet: ");
            string modelo = Console.ReadLine()!;
            Console.Write($"Digite a quantidade que deseja cadastrar: ");
            int quantidade = int.Parse(Console.ReadLine()!);
            contT++;
            Tablet t = new Tablet(contT, modelo, quantidade);
            eletronicos.Add(modelo, t);
            Console.WriteLine($"Tablet cadastrado com sucesso!!!");
            Console.WriteLine($"Aperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Deseja Cadastrar novamente?");
            Console.WriteLine($"Digite 1 para sim\nDigite 2 para voltar ao menu");
            string opcao = Console.ReadLine()!;
            switch (opcao)
            {
                case "1":
                    i = 0;
                    break;
                case "2":
                    Console.WriteLine($"Voltando ao menu principal em 2 segundos...");
                    Thread.Sleep(0);
                    i = 1;
                    break;
            }
        }

    }
}