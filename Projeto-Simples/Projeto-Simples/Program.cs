namespace ProjetoSimples;

class Program 
{
    static void Main() 
    {
        int op = 0;
        do
        {
            Console.WriteLine("Login Sucessfull!");
            Console.WriteLine("1 - Clients Menu");
            Console.WriteLine("2 - Products Menu");
            Console.WriteLine("3 - Budgets Menu");
            Console.WriteLine("4 - Sair");
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1: ClientsMenu();
                    break;
                case 2: MenuProducts();
                    break;
                case 3: MenuBudget();
                    break;
                case 4: Console.WriteLine("Saindo...");
                    break;
                default: Console.WriteLine("Invalid Option! Try again.");
                    break;
            }

        } while (op != 4);
    }
}