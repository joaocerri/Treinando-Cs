using Projeto_Simples;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ProjetoSimples;

class Program 
{
    static void Main() 
    {
        Client client = new Client();  
        Product product = new Product();    
        Budget budget = new Budget();
        Console.WriteLine("Login Sucessfull!\n");
        Console.WriteLine("Press any key to continue...");
        Console.ReadKey();

        int op = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("1 - Clients Menu");
            Console.WriteLine("2 - Products Menu");
            Console.WriteLine("3 - Budgets Menu");
            Console.WriteLine("4 - Sair");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: client.ClientsMenu();
                    break;
                case 2: product.ProductsMenu();
                    break;
                case 3: budget.BudgetMenu();
                    break;
                case 4: Console.WriteLine("Saindo...");
                    break;
                default: Console.WriteLine("Invalid Option! Try again.");
                    break;
            }
        } while (op != 4);
    }
}