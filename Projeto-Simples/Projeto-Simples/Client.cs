namespace Projeto_Simples
{
    internal class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CPF { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        int Age { get; set; }

        public void ClientsMenu()
        {
            int op = 0;
            do
            {
                Console.WriteLine("1 - Register Client");
                Console.WriteLine("2 - Edit Client");
                Console.WriteLine("3 - Exclude Client");
                Console.WriteLine("0 - Back to Main Menu");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1: RegisterClient();
                        break;
                    case 2: EditClient();
                        break;
                    case 3: ExcludeClient();
                        break;
                    default: Console.WriteLine("")
                }

            } while (op != 0); 
        }
    }
}
