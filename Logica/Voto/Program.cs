using System;

namespace Voto
{
    internal class Program
    {
        static void Main(string[] args)
        {
        /* Em uma eleição presidencial, existem quatro candidatos.Os votos são informados através de códigos.
        * Os códigos utilizados são:
            • 1,2,3,4 votos para os respectivos candidatos;
            • 5 voto nulo; 
            • 6 voto em branco.
        Assim, escreva um programa para receber um único voto e imprima: 
            • Se o usuário votou em um candidato: "Voto contabilizado com sucesso..."B
            • Se o usuário votou nulo: "Voto nulo contabilizado..."
            • Se o usuário votou em branco: "Voto branco contabilizado..
        Se o voto for diferente de todas as opções acima: "Voto inválido..."
        */
            Console.WriteLine("--Voto--\n");
            Console.WriteLine("1, 2, 3, 4 votos para os respectivos candidatos");
            Console.WriteLine("5 voto nulo");
            Console.WriteLine("6 voto em branco");

            Console.Write("Qual seu voto: ");

            int voto = int.Parse(Console.ReadLine());

            /* if (voto == 6)
                 Console.WriteLine("Voto branco contabilizado..");
             else if (voto == 5)
                 Console.WriteLine("Voto nulo contabilizado...");
             else if (voto > 6)
                 Console.WriteLine("Voto invalido");
             else if (voto < 1)
                 Console.WriteLine("Voto invalido");
             else
                 Console.WriteLine("Voto contabilizado"); */

            #region outra forma
            /*if (voto == 6)
                Console.WriteLine("Voto branco contabilizado..");
            else if (voto == 5)
                Console.WriteLine("Voto nulo contabilizado...");
            else if (voto > 6)
                Console.WriteLine("Voto invalido");
            else if (voto < 1)
                Console.WriteLine("Voto invalido");
            else
                Console.WriteLine("Voto contabilizado"); */
            #endregion

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}