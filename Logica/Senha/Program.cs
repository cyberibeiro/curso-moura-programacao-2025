using System;

namespace Senha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            * Faça um programa que solicite uma senha para o usuário.
            * Caso a senha seja igual à 123voltojah o programa deve exibir a mensagem "Acesso Total".
            * Caso contrário o programa deve exibir a mensagem "Acesso Negado".
            * Se a senha informada pelo usuário possuir menos de 4 caracteres, o programa deve exibir a mensagem "Senha deve ter mais de 3 caracteres".
             */

            const string SENHACORRETA = "123voltojah";
            const int TAMANHOMINIM0 = 4;

            Console.WriteLine("--Senha--");

            Console.Write("Digite uma senha: ");
            string senha = (Console.ReadLine());

            if (senha.Length >= TAMANHOMINIM0)
                if (senha == SENHACORRETA)
                    Console.WriteLine("Acesso Total");
                else
                    Console.WriteLine("Acesso Negado");
            else
                Console.WriteLine($"Senha deve ter mais de {TAMANHOMINIM0 - 1} caracteres");

            Console.WriteLine("--Pressione ENTER para encerrar--");
            Console.ReadLine();
        }
    }
}
