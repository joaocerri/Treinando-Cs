namespace Projeto_Simples
{
    internal class Budget
    {
        int ID { get; set; }
        int ID_Client { get; set; }
        int ID_Products { get; set; }
        double Cost { get; set; }
        DateOnly DateBuy { get; set; }

        public void BudgetMenu() { }
    }
}
