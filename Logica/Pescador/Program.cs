using System;

namespace Pescador
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /*
        Um pescador comprou um microcomputador para controlar o rendimento diário de seu trabalho.
        Toda vez que ele traz um peso de peixes maior que o estabelecido pelo regulamento de pesca do estado de 
        São Paulo (50 quilos) deve pagar uma multa de R$ 4,00 por quilo excedente. Assim, faça um
        programa que leia o peso de peixes e verifique se há excesso.
        Se houver, o programa também deve calcular o valor da multa que o pescador deverá pagar. 
        No final, o programa deve imprimir o excesso e a multa paga pelo pescador
        */

        const double PESOMAXIMOPERMITIDO = 50;
            const double MULTAPORKGEXCEDIDO = 4;

            Console.WriteLine("---Pescador---/\n");

            Console.Write("Informe o peso pescago em kg: ");
            double pesoPescado = double.Parse(Console.ReadLine());

            double pesoExcedidoEmKg = 0;
            double multaPagaPeloPescador = 0;

        if (pesoPescado > PESOMAXIMOPERMITIDO)
        {
            pesoExcedidoEmKg = pesoPescado - PESOMAXIMOPERMITIDO;
            multaPagaPeloPescador = pesoExcedidoEmKg * MULTAPORKGEXCEDIDO;
        }

            Console.WriteLine($"\nPeso excedido: {pesoExcedidoEmKg:0.00} kg");
            Console.WriteLine($"Multa: R$ {multaPagaPeloPescador}");

            Console.WriteLine("\nPressione ENTER para finalizar o programa");
            Console.ReadLine();
        }
    }
}