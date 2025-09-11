using System;

namespace ElevadorLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region (Exercício feito com o intuito de prever a saída do código:)
            /*

                        --Programa do elevador—

            Peso máximo suportado pelo elevador em kg: 500
            Número de pessoas que desejam utilizá-lo: 5
            Peso da 1 pessoa em Kg: 40
            Peso da 2 pessoa em Kg: 55,65
            Peso da 3 pessoa em Kg: 67,80
            Peso da 4 pessoa em Kg: 53
            Peso da 5 pessoa em Kg: 100
            Elevador funcionando...

            --Pressione ENTER para encerrar—

                        --Programa do elevador—

            Peso máximo suportado pelo elevador em kg: 500
            Número de pessoas que desejam utilizá-lo: 5
            Peso da 1 pessoa em Kg: 102
            Peso da 2 pessoa em Kg: 100
            Peso da 3 pessoa em Kg: 100
            Peso da 4 pessoa em Kg: 100
            Peso da 5 pessoa em Kg: 143
            Elevador não pode entrar funcionando...

            --Pressione ENTER para encerrar—
            */
            #endregion

            Console.WriteLine("--Programa do Elevador--\n");

            Console.Write("Peso máximo suportado pelo elevador em Kg:");
            double pesoMaximoSuportadoPeloElevador = double.Parse(Console.ReadLine());

            int numeroDePessoas = 0;
            bool deuCerto;
            do
            {
                Console.Write("Número de pessoas que desejam utilizá-lo:");
                deuCerto = int.TryParse(Console.ReadLine(), out numeroDePessoas);
                if (!deuCerto)
                    Console.WriteLine("Valor inválido. Tente novamente.");
                else if (numeroDePessoas < 0)
                    Console.WriteLine("Número de pessoas não pode ser negativo. Tente novamente.");
            } while (!deuCerto || numeroDePessoas < 0);

            double somaDosPesosDasPessoas = 0;

            for (int i = 0; i < numeroDePessoas; i++)
            {
                Console.Write($"Peso da {i + 1}ª pessoa em Kg:"); //não altera o valor de i.
                double pesoDaPessoa = double.Parse(Console.ReadLine());
                somaDosPesosDasPessoas += pesoDaPessoa;
            }
            if (somaDosPesosDasPessoas > pesoMaximoSuportadoPeloElevador)
                Console.WriteLine("Elevador não pode entrar em funcionamento.");
            else
                Console.WriteLine("Elevador funcionando...");

            Console.WriteLine("\n--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
