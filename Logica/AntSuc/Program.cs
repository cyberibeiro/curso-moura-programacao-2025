﻿using System;

/*
 * Faça um programa que solicite um número inteiro para o usuário
 * Calcule e mostre o Sucessor e o Antecessor.
 */
namespace AntSuc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--Antecessor e Sucessor--\n");

            Console.Write("Digite um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Antecessor: {numero - 1}");
            Console.WriteLine($"Sucessor: {numero + 1}");

            Console.WriteLine("\nPressione ENTER para encerrar");
            Console.ReadLine();
        }
    }
}
