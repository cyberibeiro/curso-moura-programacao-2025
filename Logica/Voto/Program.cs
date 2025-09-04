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

            const int CANDIDATOUM = 1;
            const int CANDIDATODOIS = 2;
            const int CANDIDATOTRES = 3;
            const int CANDIDATOQUATRO = 4;
            const int VOTONULO = 5;
            const int VOTOBRANCO = 6;

            Console.Write("Qual seu voto: ");
            int voto = int.Parse(Console.ReadLine());

            if (voto == VOTOBRANCO)
                Console.WriteLine("Voto branco contabilizado..");
            else if (voto == VOTONULO)
                Console.WriteLine("Voto nulo contabilizado...");
            else if (voto > 6)
                Console.WriteLine("Voto invalido");
            else if (voto < 1)
                Console.WriteLine("Voto invalido");
            else
                Console.WriteLine("Voto contabilizado");

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}