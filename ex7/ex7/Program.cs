using ex7;

namespace ex6;

class Program 
{   static void Main(string[] args) 
    {
        Pedido pedido1 = new Pedido();

        pedido1.SetPreco(3500.00);
        pedido1.SetDescricao("notebook");
        pedido1.SetQuantidade(2);
        
        Pedido pedido2 = new Pedido();

        pedido2.SetPreco(250.85);
        pedido2.SetDescricao("Memoria RAM");
        pedido2.SetQuantidade(5);
        
        Pedido pedido3 = new Pedido();

        pedido3.SetPreco(50.25);
        pedido3.SetDescricao("Mouse");
        pedido3.SetQuantidade(7);

        pedido1.ShowOrder();
        Console.WriteLine("\n\n");
        pedido2.ShowOrder();
        Console.WriteLine("\n\n");
        pedido3.ShowOrder();

    } 
}