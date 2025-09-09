namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tempo tempo1 = new Tempo();
            tempo1.SetHoras(12);
            tempo1.SetMinutos(65);
            tempo1.SetSegundos(37);

            Tempo tempo2 = new Tempo(23, 30, 45);

            
            Console.WriteLine("--- Exibindo os valores do Tempo 1 ---");
            Console.WriteLine("Horas tempo 1: {0:D} horas", tempo1.GetHoras());
            Console.WriteLine("Minutos tempo 1: {0:D} minutos", tempo1.GetMinutos());
            Console.WriteLine("Minutos tempo 1: {0:D} segundos", tempo1.GetSegundos());
            tempo1.ImprimirTempoCompleto();
            tempo1.ImprimirTempoSimples();
            Console.WriteLine($"Total de segundos tempo1: {tempo1.TotalSegundos()} segundos");
            
            Console.WriteLine("\n\n--- Exibindo os valores do Tempo 2 ---");
            tempo2.ImprimirTempoCompleto();
            tempo2.ImprimirTempoSimples();
            Console.WriteLine($"Total de segundos tempo2: {tempo2.TotalSegundos()} segundos");

        }


    }
}