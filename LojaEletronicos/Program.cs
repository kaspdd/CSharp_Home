using LojaEletronicos.Modelos;


Eletronico e = new Eletronico();
Celular s10 = new Celular(1,"Galaxy S10",10);
Celular s20 = new Celular(2,"Galaxy S20",10);
e.CadastrarCelular(s10);
e.CadastrarCelular(s20);
Tablet tab8 = new Tablet(1,"Galaxy Tab 8",10);
Tablet tab9 = new Tablet(2,"Galaxy Tab 9",10);
e.CadastrarTablet(tab8);
e.CadastrarTablet(tab9);
Notebook book3602 = new Notebook(1,"Galaxy Book 360 2",10);
Notebook book3603 = new Notebook(2,"Galaxy Book 360 3",10);
e.CadastrarNotebook(book3602);
e.CadastrarNotebook(book3603);

Dictionary<int, Eletronico> eletronicos = new Dictionary<int, Eletronico>();
eletronicos.Add(1, s10);
eletronicos.Add(2,s20);
eletronicos.Add(3,tab8);
eletronicos.Add(4,tab9);
eletronicos.Add(5,book3602);
eletronicos.Add(6,book3603);



void MenuPrincipal()
{
    e.ModeloTiuloMenu("Bem vindo a loja de eletronicos");
    Console.WriteLine($"Escolha uma opcao\n");
    Console.WriteLine($"Digite 1 para cadastrar um celular:");
    Console.WriteLine($"Digite 2 para cadastrar um tablet:");
    Console.WriteLine($"Digite 3 para cadastrar um notebook");
    Console.WriteLine($"Digite 4 para comprar um produto:");
    Console.WriteLine($"Digite -1 para sair");
    
    
    
    
    
    
}