using System;

class Program
{
    static void Main()
    {
        // Valores de faturamento mensal por estado
        double[] valores = {
            67836.43, // SP
            36678.66, // RJ
            29229.88, // MG
            27165.48, // ES
            19849.53  // Outros
        };

        string[] estados = { "SP", "RJ", "MG", "ES", "Outros" };

        // Calcula o valor total mensal
        double valorTotal = 0;
        foreach (double valor in valores)
        {
            valorTotal += valor;
        }

        // Calcula e imprime o percentual de representação de cada estado
        for (int i = 0; i < valores.Length; i++)
        {
            double percentual = (valores[i] / valorTotal) * 100;
            Console.WriteLine($"{estados[i]}: {percentual:F2}%");
        }
    }
}
