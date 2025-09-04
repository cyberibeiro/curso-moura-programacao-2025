using System;

namespace Elevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Peso Maximo--\n");

            Console.Write("Digite o peso maximo suportado pelo elevador em kg: ");
            double pesoMaximoElevador = double.Parse(Console.ReadLine());

            Console.Write("\nInforme o peso em Kg para as 3 pessoas: ");
            Console.Write("\nPessoa 1: ");
            double pesoPessoa1 = double.Parse(Console.ReadLine());
            Console.Write("Pessoa 2: ");
            double pesoPessoa2 = double.Parse(Console.ReadLine());
            Console.Write("Pessoa 3:");
            double pesoPessoa3 = double.Parse(Console.ReadLine());

            double pesoTotal = pesoPessoa1 + pesoPessoa2 + pesoPessoa3;

            if (pesoTotal <= pesoMaximoElevador)
                Console.WriteLine("Elevador pode entrar em funcionamento");
            else
                Console.WriteLine("Elevador NÃO pode entrar em funcionamento");

            #region "Ternário"
            /*
            bool podeEntrar = pesoTotal <= pesoMaximoElevador;
            Console.WriteLine(podeEntrar ? "Elevador pode entrar em funcionamento" : "Elevador NÃO pode entrar em funcionamento");
            */
            #endregion

            Console.WriteLine("\n--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
