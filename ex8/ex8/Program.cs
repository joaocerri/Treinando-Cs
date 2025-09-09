namespace ex8;

class Program
{
    public static void Main()
    {
        Coordenadas coordenadas1 = new Coordenadas();


        coordenadas1.SetX(double.Parse(Console.ReadLine()));
        coordenadas1.SetY(double.Parse(Console.ReadLine()));

        Console.WriteLine(coordenadas1.GetQuadrante());
    }
}