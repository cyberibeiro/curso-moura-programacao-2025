using System;

/*
Analise a seguinte informação:

Em um jogo, existe um posto que está vendendo combustíveis com a seguinte tabela de descontos:

Álcool
até 20 litros (inclusive 20 litros), desconto de 2% por litro
acima de 20 litros, desconto de 5% por litro

Gasolina
até 20 litros (inclusive 20 litros), desconto de 3% por litro
acima de 20 litros, desconto de 6% por litro

Após à análise, faça um programa que leia o número de litros vendidos 
e o tipo de combustível (codificado da seguinte forma: 1-álcool, 2-gasolina).
calcule e imprima o valor a ser pago pelo jogador, sabendo-se que 
o preço do litro da gasolina é R$ 6.10 e o preço do litro do álcool é R$ 4.20
 */


namespace Posto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double VALORLITROALCOOL = 4.2;
            const double VALORLITROGASOLINA = 6.1;
            const double VALORDESCONTOLITROALCOOLATE20LITROS = 0.02;
            const double VALORDESCONTOLITROALCOOLACIMA20LITROS = 0.05;
            const double VALORDESCONTOLITROGASOLINAATE20LITROS = 0.03;
            const double VALORDESCONTOLITROGASOLINAACIMA20LITROS = 0.06;
            const double LIMITELITROSCOMBUSTIVELPARADESCONTO = 20;
            const int ALCOOL = 1, GASOLINA = 2;

            Console.WriteLine("--Posto de Combustível--\n");

            string respostaUsuario = "s";

            do
            {
                Console.Write("Tipo de combustível (1-Álcool 2-Gasolina):");
                int tipoCombustivel = int.Parse(Console.ReadLine());
                if (tipoCombustivel != 1 && tipoCombustivel != 2)
                {
                    Console.WriteLine("Tipo de combustível inválido!");
                    //return; //return early
                    continue; // Passa para a próxima iteração. (não sai fora do loop)
                }

                double litros;
                bool litrosValidos = false;

                do
                {
                    Console.Write("Litros vendidos:");
                    litros = double.Parse(Console.ReadLine());
                    litrosValidos = litros >= 0;

                    if (!litrosValidos)
                        Console.WriteLine("Litros inválidos!");

                } while (!litrosValidos);

                double valorASerPago = 0;

                switch (tipoCombustivel)
                {
                    case ALCOOL:
                        valorASerPago = litros * VALORLITROALCOOL;
                        valorASerPago = (litros <= LIMITELITROSCOMBUSTIVELPARADESCONTO) ? valorASerPago * (1 - VALORDESCONTOLITROALCOOLATE20LITROS) : valorASerPago * (1 - VALORDESCONTOLITROALCOOLACIMA20LITROS);
                        break;
                    case GASOLINA:
                        valorASerPago = litros * VALORLITROGASOLINA;
                        valorASerPago = (litros <= LIMITELITROSCOMBUSTIVELPARADESCONTO) ? valorASerPago * (1 - VALORDESCONTOLITROGASOLINAATE20LITROS) : valorASerPago * (1 - VALORDESCONTOLITROGASOLINAACIMA20LITROS);
                        break;
                }

                Console.WriteLine($"Valor a ser pago: R$ {valorASerPago:0.00}");

                Console.Write("Deseja reabastecer (s-sim n-não)?");
                respostaUsuario = Console.ReadLine();

            } while (respostaUsuario == "s");

            Console.WriteLine("\nPressione ENTER para encerrar");
            Console.ReadLine();

            //return;
        }
    }
}


#region "Estrutura de decisão"
//if (tipoCombustivel == ALCOOL)
//{
//    valorASerPago = litros * VALORLITROALCOOL;
//    valorASerPago = (litros <= LIMITELITROSCOMBUSTIVELPARADESCONTO) ? valorASerPago * (1 - VALORDESCONTOLITROALCOOLATE20LITROS) : valorASerPago * (1 - VALORDESCONTOLITROALCOOLACIMA20LITROS);

//    //if (litros <= LIMITELITROSCOMBUSTIVELPARADESCONTO)
//    //{
//    //    valorASerPago = litros * VALORLITROALCOOL * (1 - VALORDESCONTOLITROALCOOLATE20LITROS);
//    //}
//    //else
//    //{
//    //    valorASerPago = litros * VALORLITROALCOOL * (1 - VALORDESCONTOLITROALCOOLACIMA20LITROS);
//    //}
//}
//else if (tipoCombustivel == GASOLINA)
//{
//    valorASerPago = litros * VALORLITROGASOLINA;
//    valorASerPago = (litros <= LIMITELITROSCOMBUSTIVELPARADESCONTO) ? valorASerPago * (1 - VALORDESCONTOLITROGASOLINAATE20LITROS) : valorASerPago * (1 - VALORDESCONTOLITROGASOLINAACIMA20LITROS);


//    //if (litros <= LIMITELITROSCOMBUSTIVELPARADESCONTO)
//    //{
//    //    valorASerPago = litros * VALORLITROGASOLINA * (1 - VALORDESCONTOLITROGASOLINAATE20LITROS);
//    //}
//    //else
//    //{
//    //    valorASerPago = litros * VALORLITROGASOLINA * (1 - VALORDESCONTOLITROGASOLINAACIMA20LITROS);
//    //}
//}
//else
//    Console.WriteLine("Tipo de combustível inválido");
#endregion
