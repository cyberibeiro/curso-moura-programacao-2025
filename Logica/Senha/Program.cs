using System;

/*
 * Faça um programa que solicite uma senha para o usuário.
 * Caso a senha seja igual à 123voltojah o programa deve exibir a mensagem "Acesso Total".
 * Caso contrário o programa deve exibir a mensagem "Acesso Negado".
 * Se a senha informada pelo usuário possuir menos de 4 caracteres, o programa deve exibir a mensagem "Senha deve ter mais de 3 caracteres".
 */

namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string SENHACORRETA = "123voltojah";
            const int TAMANHOMINIMOSENHA = 4;

            Console.WriteLine("--Senha--");

            bool acessou = false;

            do
            {
                Console.Write("Digite a senha:");
                string senha = Console.ReadLine();

                if (senha.Length >= TAMANHOMINIMOSENHA)
                    if (senha == SENHACORRETA)
                    {
                        Console.WriteLine("Acesso Total");
                        acessou = true;
                    }
                    else
                        Console.WriteLine("Acesso Negado");
                else
                    Console.WriteLine($"Senha deve ter mais de {TAMANHOMINIMOSENHA - 1} caracteres");

            } while (!acessou); // !acessou => acessou == false


            do
            {
                Console.Write("Digite a senha:");
                string senha = Console.ReadLine();

                if (senha.Length >= TAMANHOMINIMOSENHA)
                    if (senha == SENHACORRETA)
                    {
                        Console.WriteLine("Acesso Total");
                        break;
                    }
                    else
                        Console.WriteLine("Acesso Negado");
                else
                    Console.WriteLine($"Senha deve ter mais de {TAMANHOMINIMOSENHA - 1} caracteres");

            } while (true);


            string senhaIgor;
            do
            {
                Console.Write("Digite a senha:");
                senhaIgor = Console.ReadLine();

                if (senhaIgor.Length >= TAMANHOMINIMOSENHA)
                    if (senhaIgor == SENHACORRETA)
                        Console.WriteLine("Acesso Total");
                    else
                        Console.WriteLine("Acesso Negado");
                else
                    Console.WriteLine($"Senha deve ter mais de {TAMANHOMINIMOSENHA - 1} caracteres");

            } while (senhaIgor != SENHACORRETA);

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}