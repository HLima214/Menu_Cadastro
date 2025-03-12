// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;

List<Produto> listaProdutos = new List<Produto>();

while (true)
{
    Console.Clear();
    Console.WriteLine("Bem vindo!");
    Console.WriteLine("Selecione uma opção: ");
    Console.WriteLine("1 - Para selecionar loop ");
    Console.WriteLine("2 - Adicionar produtos ");
    Console.WriteLine("3 - Listar produtos ");
    Console.WriteLine("4 - Para Sair ");
    Console.WriteLine("Digite o que deseja: ");

    string escolha = Console.ReadLine();
    Console.Clear();

    switch (escolha)
    {
        case "1":
            ExecutarLoops();
            break;
        case "2":
            adicionarProdutos();
            break;
        case "3":
            lerprodutos();
            break;
        case "4":
            Console.WriteLine("Saindo...");
            return;
        default:
            Console.WriteLine("Você digitou uma opção invalida");
            break;
    

    }

    Console.ReadKey();
}
static void ExecutarLoops()
{
    Console.Write("Executando exemplos de loop...");

    Console.WriteLine("\nExemplo de FOR: ");
    for (int i = 1; i <= 5; i++)
    {
        Console.WriteLine($"Número: {i}");
    }

    Console.WriteLine("\nExemplo de WHILE: ");
    int contadorwhile = 1;
    while (contadorwhile <= 5)
    {
        Console.WriteLine($"Número: {contadorwhile}");
        contadorwhile++;
    }

    Console.WriteLine("\nExemplo de DO-WHILE: ");
    int contadorDowhile = 1;
    do
    {
        Console.WriteLine($"Número: {contadorDowhile}");
        contadorDowhile++;
    }while (contadorDowhile <= 5);

    Console.WriteLine("\nExemplo FOREACH: ");
    string[] cores = { "Vermelho", "Azul", "Verde", "Amarelo" };
    foreach(string cor in cores)
    {
        Console.WriteLine($"Cor: {cor}");
    }

}



void adicionarProdutos()
{
    Produto item1 = new Produto();
    item1.Nome = "Big Tasty";
    item1.Preco = "32.90";

    listaProdutos.Add(item1);

    Produto item2 = new Produto();
    item2.Nome = "Big Mac";
    item2.Preco = "29.90";

    listaProdutos.Add(item2);
}

void lerprodutos()
{
    if (listaProdutos.Count == 0)
    {
        Console.WriteLine("Necessário adicionar produtos...");
    }

    else { 
        foreach (Produto item in listaProdutos)
        {
            Console.WriteLine($"\nNome produto: {item.Nome}");
            Console.WriteLine($"\nPreço produto: {item.Preco}");
        }
    }
}
class Produto
{
    public string Nome { get; set; }

    public string Preco { get; set; }
}






