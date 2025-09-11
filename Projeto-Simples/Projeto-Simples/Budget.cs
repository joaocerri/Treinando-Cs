namespace Projeto_Simples
{
    internal class Budget
    {
        int ID { get; set; }
        int ID_Client { get; set; }
        int ID_Products { get; set; }
        double Cost { get; set; }
        DateOnly DateBuy { get; set; }
        public void ShowBudgetMenu()
        {
            Console.WriteLine("1 - Register Budget");
            Console.WriteLine("2 - Edit Budget");
            Console.WriteLine("3 - Exclude Budget");
            Console.WriteLine("4 - View Budget Report");
            Console.WriteLine("0 - Back to Main Menu");
        }

        public void BudgetMenu()
        {
            int op = 0;
            do
            {
                Console.Clear();
                ShowBudgetMenu();
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Voltando para o menu principal... ");
                        break;
                    case 1:
                        RegisterBudget();
                        Console.Clear();
                        break;
                    case 2:
                        EditBudget();
                        Console.Clear();
                        break;
                    case 3:
                        ExcludeBudget();
                        Console.Clear();
                        break;
                    case 4:
                        BudgetReport();
                        Console.Clear();
                        break;
                    default:
                        Console.WriteLine("");
                        Console.Clear();
                        break;
                }
            } while (op != 0);
        }
        
        public void RegisterBudget() { }
        public void EditBudget() { }
        public void ExcludeBudget() { }
        public void BudgetReport() { } 
    }
}
