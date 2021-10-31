/*
Criar um programa que permita que o usuário digite um número, verificar e mostrar na tela se o
número é positivo, negativo ou zero.
*/
using System;

namespace Ex8___AULA_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("╔══════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("║                                                      ║");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("║                                                      ║");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("║                                                      ║");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("║                                                      ║");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("║                                                      ║");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("║                                                      ║");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("║                                                      ║");
            Console.SetCursorPosition(3, 11);
            Console.WriteLine("╚══════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(19, 6);
            Console.Write("Digite um número: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(15, 9);
            if (num > 0)
            {
                Console.WriteLine("O numero digitado é positivo.");
            }
            else if (num == 0)
            {
                Console.WriteLine("O numero digitado é igual a '0'.");
            }
            else
            {
                Console.WriteLine("O numero digitado é negativo.");
            }
            Console.ReadKey();
        }
    }
}
