using System;

/*
 * 3 amigos => fazem apostas
 * ganharam o prêmio
 * Quanto cada um recebe? * 
 *  R.: Depende de quanto cada um apostou.
 *  R.: Quanto é o prêmio!!!
 *  
 * Como faremos o programa para calcular
 * Entrada => Valor do prêmio e valor das apostas de cada amigo.
 * Processamento => Cálculo de quanto cada um recebe. (%)
 * Saída => Impressão do valor que cada amigo recebe.
*/

namespace Loteria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Loteria--");

            Console.WriteLine("Informe os dados sobre a loteria");

            Console.Write("Valor do prêmio:");
            double valorPremio = double.Parse(Console.ReadLine());

            Console.WriteLine("Valores apostados pelos três amigos");

            Console.Write("Amigo 1:");
            double valorApostadoAmigo1 = double.Parse(Console.ReadLine());
            Console.Write("Amigo 2:");
            double valorApostadoAmigo2 = double.Parse(Console.ReadLine());
            Console.Write("Amigo 3:");
            double valorApostadoAmigo3 = double.Parse(Console.ReadLine());

            double somaValorApostadoPelosAmigos = valorApostadoAmigo1 + valorApostadoAmigo2 + valorApostadoAmigo3;

            Console.WriteLine("Valores recebidos");
            Console.WriteLine($"Amigo1: {valorApostadoAmigo1 / somaValorApostadoPelosAmigos * valorPremio:0.00}");
            Console.WriteLine($"Amigo2: {valorApostadoAmigo2 / somaValorApostadoPelosAmigos * valorPremio:0.00}");
            Console.WriteLine($"Amigo3: {valorApostadoAmigo3 / somaValorApostadoPelosAmigos * valorPremio:0.00}");

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
