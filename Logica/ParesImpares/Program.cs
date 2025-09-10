using System;

/*
 * Imprimir todos numeros pares entre 0 e 300.
 * Imprimir todos numeros ímpares entre 0 e 300.
 */

namespace ParesImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Pares--\n");

            for (int i = 0; i < 301; i += 2)
                Console.Write($"{i} - ");

            Console.WriteLine();

            for (int i = 0; i < 301; i++)
            {
                if (i % 2 == 0)
                    Console.Write($"{i} - ");
            }

            Console.WriteLine();

            int n = 0;
            while (n < 301)
            {
                Console.Write($"{n} - ");
                n += 2;
            }

            Console.WriteLine();

            n = 0;
            while (n < 301)
            {
                if (n % 2 == 0)
                    Console.Write($"{n} - ");
                n++;
            }


            Console.WriteLine("\n\n--Ímpares--\n");

            for (int i = 1; i < 300; i += 2)
                Console.Write($"{i} - ");

            Console.WriteLine();

            n = 1;
            do
            {
                Console.Write($"{n} - ");
                n += 2;
            } while (n < 301);

            Console.WriteLine("\n--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
