using System.Reflection.Metadata.Ecma335;

namespace Ex5;
public class Retangulo
{
   public double Altura;
   public double Largura;
   
   public void GetAltura(double altura)
    {
        if (altura >= 1.0 && altura <= 20.0)
        {
            this.Altura = altura;
        }
        else
        {
            Console.WriteLine("Impossivel atribuir esse valor para a altura!");
        }
    }
   public void GetLargura(double largura)
    {
        if(largura>=1.0 && largura <= 20.0)
        {
            Largura = largura;
        }
        else
        {
            Console.WriteLine("Impossivel atribuir esse valor para a largura!");
        }
    }
    public double CalcularArea() => Altura * Largura;
    public double CalcularPerimetro() => (Altura*2)+Largura*2;
}
