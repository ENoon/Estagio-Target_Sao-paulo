using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.IO;
using System.Globalization;

class Program
{
    static void Main()
    {
        try
        {
            // Caminho do arquivo XML
            string filePath = "C:/Users/noons/Documents/prg no vscode/dadoss.xml";

            // Verificar se o arquivo existe
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Arquivo XML não encontrado.");
                return;
            }

            // Ler o conteúdo do arquivo XML e adicionar um elemento raiz
            string xmlContent = File.ReadAllText(filePath);
            xmlContent = "<root>" + xmlContent + "</root>"; // Adiciona um elemento raiz chamado <root>

            // Carregar o XML modificado em um XDocument
            XDocument xmlDoc = XDocument.Parse(xmlContent);

            // Inicializar uma lista para armazenar os valores de faturamento
            List<decimal> faturamentos = new List<decimal>();

            // Iterar sobre os elementos 'row' para extrair os valores de faturamento
            foreach (var row in xmlDoc.Descendants("row"))
            {
                decimal valor = decimal.Parse(row.Element("valor").Value, CultureInfo.InvariantCulture);

                if (valor > 0) // Ignorar dias com faturamento zero
                {
                    faturamentos.Add(valor);
                }
            }

            // Verificar se há valores válidos
            if (faturamentos.Count == 0)
            {
                Console.WriteLine("Não há valores de faturamento válidos para calcular.");
                return;
            }

            // Calcular o menor e maior valor de faturamento
            decimal menorFaturamento = faturamentos.Min();
            decimal maiorFaturamento = faturamentos.Max();

            // Calcular a média mensal
            decimal mediaMensal = faturamentos.Average();


            // Calcular o número de dias com faturamento superior à média mensal
            int diasAcimaDaMedia = faturamentos.Count(valor => valor > mediaMensal);

            // Exibir os resultados
            Console.WriteLine($"Menor valor de faturamento: {menorFaturamento:F2}");
            Console.WriteLine($"Maior valor de faturamento: {maiorFaturamento:F2}");
            Console.WriteLine($"Número de dias com faturamento acima da média: {diasAcimaDaMedia}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}
