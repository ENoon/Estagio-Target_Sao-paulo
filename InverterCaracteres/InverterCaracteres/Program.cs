using System;

class Program
{
    static void Main()
    {
        // String a ser invertida (pode ser definida ou informada pelo usuário)
        Console.Write("Digite uma string para inverter: ");
        string input = Console.ReadLine();

        // Inverte a string
        string reversed = InverterString(input);

        // Exibe a string invertida
        Console.WriteLine($"String invertida: {reversed}");
    }

    static string InverterString(string str)
    {
        // Variável para armazenar a string invertida
        string resultado = "";

        // Loop para construir a string invertida
        for (int i = str.Length - 1; i >= 0; i--)
        {
            resultado += str[i];
        }

        // Retorna a string invertida
        return resultado;
    }
}
