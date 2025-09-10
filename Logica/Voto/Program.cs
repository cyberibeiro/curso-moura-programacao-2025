using System;

/* Em uma eleição presidencial, existem quatro candidatos.Os votos são informados através de códigos.
 * Os códigos utilizados são:
    • 1,2,3,4 votos para os respectivos candidatos;
    • 5 voto nulo; 
    • 6 voto em branco.
    Assim, escreva um programa para receber um único voto e imprima: 
    • Se o usuário votou em um candidato: "Voto contabilizado com sucesso..."
    • Se o usuário votou nulo: "Voto nulo contabilizado..."
    • Se o usuário votou em branco: "Voto branco contabilizado..."
      Se o voto for diferente de todas as opções acima: "Voto inválido..."
*/


namespace Voto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int CANDIDATO1 = 1, CANDIDATO2 = 2, CANDIDATO3 = 3, CANDIDATO4 = 4, NULO = 5, BRANCO = 6;

            Console.WriteLine("--Voto--\n");
            Console.WriteLine("1,2,3,4 votos para os respectivos candidatos");
            Console.WriteLine("5 voto nulo");
            Console.WriteLine("6 voto em branco");

            Console.Write("Voto:");

            #region "Solução com voto do tipo int e ED encadeada e operadores lógicos - E"
            /*            
            int voto = int.Parse(Console.ReadLine());

            //if (voto > 0 && voto < 5)
            if (voto >= CANDIDATO1 && voto <= CANDIDATO4)
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == NULO)
                Console.WriteLine("Voto nulo contabilizado...");
            else if (voto == BRANCO)
                Console.WriteLine("Voto branco contabilizado...");
            else
                Console.WriteLine("Voto inválido...");
            */
            #endregion

            #region "Solução com voto do tipo int e ED encadeada e operadores lógicos - OU"

            /*
            int voto = int.Parse(Console.ReadLine());

            if (voto == 1 || voto == 2 || voto == 3 || voto == 4)
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == 5)
                Console.WriteLine("Voto nulo contabilizado...");
            else if (voto == 6)
                Console.WriteLine("Voto branco contabilizado...");
            else
                Console.WriteLine("Voto inválido...");
            */
            #endregion

            #region "****Solução com voto do tipo int e Estrutura de Seleção (switch)****"

            int voto = int.Parse(Console.ReadLine());

            switch (voto)
            {
                case CANDIDATO1:
                case CANDIDATO2:
                case CANDIDATO3:
                case CANDIDATO4:
                    Console.WriteLine("Voto contabilizado com sucesso...");
                    break;
                case NULO:
                    Console.WriteLine("Voto nulo contabilizado...");
                    break;
                case BRANCO:
                    Console.WriteLine("Voto branco contabilizado...");
                    break;
                default:
                    Console.WriteLine("Voto inválido...");
                    break;
            }

            #endregion

            #region "Solução com voto do tipo int e ED encadeada"
            /*
            int voto = int.Parse(Console.ReadLine());

            if (voto == 1)
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == 2)
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == 3)
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == 4)
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == 5)
                Console.WriteLine("Voto nulo contabilizado...");
            else if (voto == 6)
                Console.WriteLine("Voto branco contabilizado...");
            else
                Console.WriteLine("Voto inválido...");
            */
            #endregion

            #region "Solução com voto do tipo string e ED encadeada"
            /*
            string voto = Console.ReadLine();

            if (voto == "1")
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == "2")
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == "3")
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == "4")
                Console.WriteLine("Voto contabilizado com sucesso...");
            else if (voto == "5")
                Console.WriteLine("Voto nulo contabilizado...");
            else if (voto == "6")
                Console.WriteLine("Voto branco contabilizado...");
            else
                Console.WriteLine("Voto inválido...");
            */
            #endregion

            Console.WriteLine("\nPressione ENTER para encerrar");
            Console.ReadLine();
        }
    }
}