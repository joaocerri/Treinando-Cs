
namespace ex1._2
{
    class Program
    {
        static void Main(string[] args)
        {
        Lampada lampada1 = new Lampada();
        Lampada lampada2 = new Lampada();

        lampada1.Acender();
        lampada2.Acender();
        lampada2.Apagar();

        Console.WriteLine(lampada1.MostrarEstado());
        Console.WriteLine(lampada2.MostrarEstado());          
        }
    }
}