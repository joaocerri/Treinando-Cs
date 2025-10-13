using System;
using System.Collections.Generic;
using System.Linq;

class Result
{
    private static int IsUnstable(List<int> request, int i)
    {
        if (i <= 0 || i >= request.Count - 1)
            return 0;

        int previous = request[i - 1];
        int current = request[i];
        int next = request[i + 1];

        if (current > previous && current > next)
            return 1;

        if (current < previous && current < next)
            return 1;

        return 0;
    }


    public static int getMinInstability(List<int> request)
    {
        int n = request.Count;

        if (n < 3)
            return 0;

        int initialInstability = 0;
        for (int i = 1; i < n - 1; i++)
        {
            initialInstability += IsUnstable(request, i);
        }

        int minInstability = initialInstability;


        for (int i = 0; i < n; i++)
        {
            int originalValue = request[i];

            HashSet<int> candidates = new HashSet<int>();

            if (i > 0)
                candidates.Add(request[i - 1]);

            if (i < n - 1)
                candidates.Add(request[i + 1]);

            foreach (int candidateValue in candidates)
            {
                int oldLocalINstability = 0;
                int newLocalInstability = 0;

                int start = Math.Max(1, i - 2);
                int end = Math.Min(n - 2, i + 2);

                for (int j = start; j <= end; j++)
                {
                    request[i] = originalValue;
                    oldLocalINstability += IsUnstable(request, j);

                    request[i] = candidateValue;
                    newLocalInstability += IsUnstable(request, j);
                }

                int newInstability = initialInstability - oldLocalINstability + newLocalInstability;

                minInstability = Math.Min(minInstability, newInstability);
            }

            request[i] = originalValue;
        }
        return minInstability;
    }

}

class Solution
{
    public static void RunTest(List<int> requestData, string testName)
    {
        List<int> request = new List<int>(requestData);
        
        int result = Result.getMinInstability(request);

        Console.WriteLine($"--- {testName} ---");
        Console.WriteLine($"Entrada: [{string.Join(", ", requestData)}]");
        Console.WriteLine($"Resultado da Instabilidade Mínima: {result}");
        Console.WriteLine("---------------------");
    }

    public static void Main(string[] args)
    {
        RunTest(new List<int> { 1, 2, 1, 2 }, "Exemplo do Enunciado");

        RunTest(new List<int> { 5, 10, 5, 1 }, "Pico Simples");
        
        RunTest(new List<int> { 1, 5, 1, 5, 1 }, "Instabilidade Restante");
    }
}