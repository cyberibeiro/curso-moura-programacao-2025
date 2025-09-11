using System;

namespace PrePro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 89;

            int valorPos = contador++;
            //valorPos = contador;
            //contador = contador + 1;
            Console.WriteLine(contador);
            Console.WriteLine(valorPos);

            int valorPre = ++contador;
            //contador = contador + 1;    
            //valorPree = contador;
            Console.WriteLine(contador);
            Console.WriteLine(valorPre);

            int x = contador += 2;
            // int x = contador = contador + 2;
            Console.WriteLine(x);

            int valorPosPre = ++contador * 2 + 28;
            Console.WriteLine(valorPosPre);

            contador--;
            --contador;
        }
    }
}
