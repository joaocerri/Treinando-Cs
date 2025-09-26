using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace ex9
{
    public class triangulo
    {
        double lado1;
        double lado2;
        double lado3;

        public triangulo()
        {
            lado1 = 1.0;
            lado2 = 1.0;
            lado3 = 1.0;
        }

        public double getLado1() => lado1;
        public double getLado2() => lado2;
        public double getLado3() => lado3;

        public void SetLados(double Lado1, double Lado2, double Lado3)
        {
            if (Lado1 >= 1 && Lado2 >= 1 && Lado3 >= 1)
            {
                if (Lado1 < Lado2 + Lado3 && Lado2 < Lado1 + Lado3 && Lado3 < Lado1 + Lado2)
                {
                    this.lado1 = Lado1;
                    this.lado2 = Lado2;
                    this.lado3 = Lado3;
                }
                else
                    Console.WriteLine("Os valores inseridos não formam um triângulo.");
            }
            else
                Console.WriteLine("Os valores dos lados devem ser maiores ou iguais a 1.");
        }

        public string GetTipo()
        {
            if (lado1 == lado2 && lado2 == lado3)
                return "Equilátero";
            
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                return "Isósceles";
            
            else
                return "Escaleno";
        }

    }
}
