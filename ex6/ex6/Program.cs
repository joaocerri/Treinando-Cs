namespace ex6;

class Program
{
    static void Main(string[] args)
    {
        Disciplina disciplina1 = new Disciplina("Otávio Dias", "Programação Orientada a Objetos");
        disciplina1.SetNota1Bi(7.5);
        disciplina1.SetNota2Bi(8.0);

        Console.WriteLine($"N1: {disciplina1.GetNota1Bi():F2}");
        Console.WriteLine($"N2: {disciplina1.GetNota2Bi():F2}");
        Console.WriteLine($"Media: {disciplina1.Media():F2}");
        Console.WriteLine($"Situação: {disciplina1.Conceito()}");
        
        Disciplina disciplina2 = new Disciplina("Yasmin Lima", "Engenharia de Software");
        disciplina2.SetNota1Bi(5.5);
        disciplina2.SetNota2Bi(6.0);

        Console.WriteLine($"\n\nN1: {disciplina2.GetNota1Bi():F2}");
        Console.WriteLine($"N2: {disciplina2.GetNota2Bi():F2}");
        Console.WriteLine($"Media: {disciplina2.Media():F2}");
        Console.WriteLine($"Situação: {disciplina2.Conceito()}");

    }

}