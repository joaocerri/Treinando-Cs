using ex2;
using System;
namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data1 = new Data();

            data1.Set(18, 10, 2006);

            Console.WriteLine(data1.DataFormatada());

            Console.WriteLine(data1.DataExtenso());
        }
    }
}
