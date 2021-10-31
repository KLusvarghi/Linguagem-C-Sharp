/*
Crie um programa que leia um número do teclado até que encontre um número igual a zero.
No final, mostre a soma dos números digitados.
*/
using System;

namespace Ex4___AULA_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            double num;
            double soma = 0;
            inicio:
            do{
                try {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Digite o " + i + "º número: ");
                    Console.ForegroundColor = ConsoleColor.White;
                    num = Convert.ToDouble(Console.ReadLine());
                    soma = soma + num;
                    i++;
                }
                catch {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("");
                    Console.WriteLine("Valor inválido!");
                    Console.WriteLine("");
                    goto inicio;
                }
            } while (num != 0);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("");
            Console.WriteLine("A soma dos números digitados é: " + soma);
            Console.ReadKey();
        }
    }
}
