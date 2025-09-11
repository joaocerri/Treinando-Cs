namespace Projeto_Simples
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        int Age { get; set; }

        public void ShowClientsMenu() 
        {
            Console.WriteLine("1 - Register Client");
            Console.WriteLine("2 - Edit Client");
            Console.WriteLine("3 - Exclude Client");
            Console.WriteLine("4 - View Client Report");
            Console.WriteLine("0 - Back to Main Menu");
        }
        
        public void ClientsMenu()
        {
            int op = 0;
            do
            {
                Console.Clear();
                ShowClientsMenu();
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0: Console.WriteLine("Voltando para o menu principal... ");
                        break;
                    case 1: RegisterClient();
                        break;
                    case 2: EditClient();
                        break;
                    case 3: ExcludeClient();
                        break;
                    case 4: ClientReport();
                        break;
                    default: Console.WriteLine("");
                        break;
                }
            } while (op != 0); 
        }

        public void RegisterClient() { }
        public void EditClient() { }
        public void ExcludeClient() { }
        public void ClientReport() { }
    }
}
