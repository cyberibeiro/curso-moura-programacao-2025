using System;

namespace Jogo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string resposta = "";
            int pontosSoco = 0;
            int pontosChute = 0;
            int pontosMagia = 0;
            int totalgolpes = 0;
            int soco = 0;
            int chute = 0;
            int magia = 0;

            do
            {
                Console.WriteLine("--Joguinho");
                Console.WriteLine("Soco (s) Chute (c) Magia (m) ou (x) para sair.");
                Console.Write("Qual golpe deseja efetuar?: ");
                resposta = Console.ReadLine();

                if (resposta == "s")
                {
                    Console.WriteLine("Golpe Contabilizado");
                    soco += 1;
                    pontosSoco += 2;
                }
                else if (resposta == "c")
                {
                    chute += 1;
                    pontosChute += 5;
                    Console.WriteLine("Golpe Contabilizado");
                }
                else if (resposta == "m")
                {
                    magia += 1;
                    pontosMagia += 10;
                    Console.WriteLine("Golpe Contabilizado");
                }
                else
                    Console.WriteLine("Inválido");


                Console.Clear();


            } while (resposta != "x");

            Console.WriteLine($"Socos - {soco} Pontos soco- {pontosSoco}");
            Console.WriteLine($"Chutes - {chute} Pontos chute- {pontosChute}");
            Console.WriteLine($"Magias - {magia} Pontos magia- {pontosMagia}");
            Console.WriteLine($"Pontos Totais- {pontosSoco + pontosChute + pontosMagia}");

            Console.Write("Pressione Enter para sairr");
            Console.ReadLine();

        }
    }
}
