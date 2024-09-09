using System;

class Program
{
    // Função para verificar se um número pertence à sequência de Fibonacci
    static bool IsFibonacci(int n)
    {
        if (n < 0) return false;
        int a = 0, b = 1;

        
        if (n == a || n == b) return true;

        while (b < n)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

   
        return b == n;
    }

    static void Main()
    {
        Console.Write("Digite um número para verificar se pertence à sequência de Fibonacci: ");

        if (int.TryParse(Console.ReadLine(), out int number))
        {
            // Verifica e exibe se o número pertence ou não à sequência de Fibonacci
            if (IsFibonacci(number))
            {
                Console.WriteLine($"O número {number} pertence à sequência de Fibonacci.");
            }
            else
            {
                Console.WriteLine($"O número {number} NÃO pertence à sequência de Fibonacci.");
            }
        }
        else
        {
            Console.WriteLine("Entrada inválida. Por favor, insira um número inteiro.");
        }
    }
}
