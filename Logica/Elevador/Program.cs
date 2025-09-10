using System;

/*
 Faça um programa que mostre se um elevador pode entrar em funcionamento ou não.
 Primeiro, o programa deve solicitar o peso máximo, em Kg, suportado pelo elevador e
 3 pessoas irão utilizá-lo. Depois, solicitar o peso de cada pessoa e, no
 final, exibir se o elevador poderá entrar em funcionamento ou não. Caso a soma dos pesos
 das pessoas for maior que o peso máximo suportado pelo elevador, ele não poderá entrar
 em funcionamento.
 */


namespace Elevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Elevador--");

            Console.Write("Peso máximo suportado pelo elevador em Kg:");
            double pesoMaximoSuportadoPeloElevador = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o peso em Kg para as 3 pessoas:");
            Console.Write("Pessoa 1:");
            double pesoPessoa1 = double.Parse(Console.ReadLine());
            Console.Write("Pessoa 2:");
            double pesoPessoa2 = double.Parse(Console.ReadLine());
            Console.Write("Pessoa 3:");
            double pesoPessoa3 = double.Parse(Console.ReadLine());

            double somaPesoPessoas = pesoPessoa1 + pesoPessoa2 + pesoPessoa3;
            bool podeSubir = somaPesoPessoas <= pesoMaximoSuportadoPeloElevador;

            /*
            if (podeSubir)
                Console.WriteLine("Elevador pode entrar em funcionamento");
            else
                Console.WriteLine("Elevador NÃO pode entrar em funcionamento");
            */

            //operador condicional - ternário
            Console.WriteLine(podeSubir ? "Elevador pode entrar em funcionamento" : "Elevador NÃO pode entrar em funcionamento");

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
