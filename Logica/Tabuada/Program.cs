using System;

/*
 * --Tabuada--
 * 
 * Informe o número da tabuada: 5
 * 5 x 0 = 0
 * 5 x 1 = 5
 * 5 x 2 = 10
 * .
 * .
 * .
 * 5 x 10 = 50
 * 
 * Pressione o ENTER para encerrar.
 */

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Tabuada--\n");

            string respostaUsuario;

            do
            {
                Console.Write("Informe o número da tabuada:");
                int tabuada = int.Parse(Console.ReadLine());

                Console.WriteLine("\n--Tabuada FOR--");
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine($"{tabuada} x {i} = {tabuada * i}");
                }

                Console.Write("Deseja fazer outra tabuada (s-sim n-não)?");
                respostaUsuario = Console.ReadLine();

            } while (respostaUsuario == "s");

            Console.WriteLine("\nPressione ENTER para encerrar");
            Console.ReadLine();
        }
    }
}


// Outras formas de resolução

/*
            Console.WriteLine("\n--Tabuada WHILE--");
            int j = 0;
            while (j < 11)
            {
                Console.WriteLine($"{tabuada} x {j} = {tabuada * j}");
                j++;
            }
            
            Console.WriteLine("\n--Tabuada DO WHILE--");
            int h = 0;
            do
            {                
                Console.WriteLine($"{tabuada} x {h} = {tabuada * h}");
                h++;
            } while (h < 11);

            #region "Sem estrutura de repetição"

            //Console.WriteLine($"{tabuada} x 0 = {tabuada * 0}");
            //Console.WriteLine($"{tabuada} x 1 = {tabuada * 1}");
            //Console.WriteLine($"{tabuada} x 2 = {tabuada * 2}");
            //Console.WriteLine($"{tabuada} x 3 = {tabuada * 3}");
            //Console.WriteLine($"{tabuada} x 4 = {tabuada * 4}");
            //Console.WriteLine($"{tabuada} x 5 = {tabuada * 5}");
            //Console.WriteLine($"{tabuada} x 6 = {tabuada * 6}");
            //Console.WriteLine($"{tabuada} x 7 = {tabuada * 7}");
            //Console.WriteLine($"{tabuada} x 8 = {tabuada * 8}");
            //Console.WriteLine($"{tabuada} x 9 = {tabuada * 9}");
            //Console.WriteLine($"{tabuada} x 10 = {tabuada * 10}");

            #endregion
            */
