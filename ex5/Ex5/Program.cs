namespace Ex5;
class Program
{
    static void Main(string[] args)
    {
        Retangulo retangulo1 = new Retangulo();
        retangulo1.GetAltura(10.2);
        retangulo1.GetLargura(5.9);

        Console.WriteLine($"Largura do retangulo 1: {retangulo1.Largura:F2}");
        Console.WriteLine($"Altura do retangulo 1: {retangulo1.Altura:F2}");
        Console.WriteLine($"{retangulo1.CalcularArea():F2}");
        Console.WriteLine($"{retangulo1.CalcularPerimetro():F2}");
        
        Retangulo retangulo2 = new Retangulo();
        retangulo2.GetAltura(7.8);
        retangulo2.GetLargura(4.3);
        
        Console.WriteLine($"Largura do retangulo 2: {retangulo2.Largura:F2}");
        Console.WriteLine($"Altura do retangulo 2: {retangulo2.Altura:F2}");
        Console.WriteLine($"{retangulo2.CalcularArea():F2}");
        Console.WriteLine($"{retangulo2.CalcularPerimetro():F2}");
        
        Retangulo retangulo3 = new Retangulo();
        retangulo3.GetAltura(5.8);
        retangulo3.GetLargura(2.3);
        
        Console.WriteLine($"Largura do retangulo 3: {retangulo3.Largura:F2}");
        Console.WriteLine($"Altura do retangulo 3: {retangulo3.Altura:F2}");
        Console.WriteLine($"{retangulo3.CalcularArea():F2}");
        Console.WriteLine($"{retangulo3.CalcularPerimetro():F2}");
    }

}