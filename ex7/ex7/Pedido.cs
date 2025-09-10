using System.Diagnostics;
using System.Net;
using System.Reflection.Metadata;

namespace ex7
{
    internal class Pedido
    {
        string Description;
        double Price;
        int Amount;

        public Pedido()
        {
            Description = "";
            Price = 0.0;
            Amount = 0;
         }

        public void SetDescricao(string description) => this.Description = description;
        public void SetPreco(double price) => this.Price = (price > 10 && price < 1000) ? price : this.Price;       
        public void SetQuantidade(int amount) => this.Amount = (amount > 0 && amount < 100) ? amount : this.Amount;  
        public string GetDescription() => Description;
        public double GetPreco() => Price;
        public int GetAmount() => Amount;
        public double GetFullValue() => Price * Amount;
        public void ShowOrder() 
        {
            Console.WriteLine($"Quantidade: {Amount}");

            if (Price > 10 && Price < 1000)
                Console.WriteLine($"Preco: {GetFullValue():C2}"); 

            else 
                Console.WriteLine("Preco Invalido!"); 

            Console.WriteLine($"Descrição: {Description}");
      
        }
    }
}