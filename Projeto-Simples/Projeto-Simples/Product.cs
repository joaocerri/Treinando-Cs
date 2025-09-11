namespace Projeto_Simples
{
    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double CostPrice { get; set; }
        public double SellPrice { get; set; }
        public string Supplier { get; set; }
        public void ClientsProduct() { }
        public void ShowProductsMenu() 
        {
            Console.WriteLine("1 - Register Product");
            Console.WriteLine("2 - Edit Product");
            Console.WriteLine("3 - Exclude Product");
            Console.WriteLine("4 - View Product Report ");
            Console.WriteLine("0 - Back to Main Menu");
        }
        public void ProductsMenu() 
        {
            int op = 0;

            do
            {
                Console.Clear();
                ShowProductsMenu();
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("\n");
                        break;
                    case 1:
                        RegisterProduct();
                        break;
                    case 2:
                        EditProduct();
                        break;
                    case 3:
                        ExcludeProduct();
                        break;
                    case 4:
                        ProductReport();
                        break;
                    default:
                        Console.WriteLine("Invalid Option. Try Again!\n");
                        break;
                }
            } while (op != 0);
        }

        public void RegisterProduct() { }
        public void EditProduct() { }
        public void ExcludeProduct() { }
        public void ProductReport() { }
    }

}
