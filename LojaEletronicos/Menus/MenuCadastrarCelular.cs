namespace LojaEletronicos.Menus;

using System.Threading.Channels;
using LojaEletronicos.Modelos;

internal class MenuCadastrarCelular : Menu
{
    public override void Executar(Dictionary<string, Eletronico> eletronicos)
    {
        base.Executar(eletronicos);
        Eletronico e = new Eletronico();
        ModeloTiuloMenu("Cadastrar Celular");
        int contC = 2;
        int contE = eletronicos.Keys.Count;
        int i = 0;

        while (i == 0)
        {
            Console.Write($"Digite o modelo do celular: ");
            string modelo = Console.ReadLine()!;
            Console.Write($"Digite a quantidade que deseja cadastrar: ");
            int quantidade = int.Parse(Console.ReadLine()!);
            contC++;
            Celular c = new Celular(contC, modelo, quantidade);
            eletronicos.Add(modelo, c);
            Console.WriteLine($"Celular cadastrado com sucesso!!!");
            Console.WriteLine($"Aperte qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine($"Deseja Cadastrar novamente?");
            Console.WriteLine($"Digite 1 para sim\nDigite 2 para voltar ao menu");
            string opcao = Console.ReadLine()!;
            switch (opcao)
            {
                case "1":
                    Console.WriteLine($"Voltando a tela de cadastro");
                    
                    break;
                case "2":
                    Console.WriteLine($"Voltando ao menu principal em 2 segundos...");
                    Thread.Sleep(2000);
                    i = 2;
                    break;
            }
        }

    }
}