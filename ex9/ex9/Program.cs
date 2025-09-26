namespace ex9;

public class Program
{
    static void Main(string[] args)
    {
        triangulo t1 = new triangulo();
        triangulo t2 = new triangulo();
        triangulo t3 = new triangulo();

        t1.SetLados(5, 5, 5);
        t2.SetLados(7, 7, 5);
        t3.SetLados(6, 9, 45);

        Console.WriteLine($"Triangulo 1: ({t1.getLado1()}, {t1.getLado2()}, {t1.getLado3()}) - {t1.GetTipo()}");
        Console.WriteLine($"Triangulo 2: ({t2.getLado1()}, {t2.getLado2()}, {t2.getLado3()}) - {t2.GetTipo()}");
        Console.WriteLine($"Triangulo 3: ({t3.getLado1()}, {t3.getLado2()}, {t3.getLado3()}) - {t3.GetTipo()}");
     }
}