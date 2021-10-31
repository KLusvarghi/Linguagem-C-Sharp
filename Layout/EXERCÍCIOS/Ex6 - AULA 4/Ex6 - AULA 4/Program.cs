// Criar um programa que permita que o usuário digite um número, verificar se o mesmo é múltiplo de 5.
using System;

namespace Ex6___AULA_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("╔═══════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("║                                                               ║");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("║                                                               ║");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("║                                                               ║");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("║                                                               ║");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("║                                                               ║");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("║                                                               ║");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("║                                                               ║");
            Console.SetCursorPosition(3, 11);
            Console.WriteLine("║                                                               ║");
            Console.SetCursorPosition(3, 12);
            Console.WriteLine("║                                                               ║");
            Console.SetCursorPosition(3, 13);
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(12, 5);
            Console.Write("Digite um número: ");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(12, 6);
            double num = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(12, 10);
            if (num % 5 == 0)
            {
                Console.Write("O número digitado é multiplo de 5.");
            }
            else
            {
             Console.Write("O número digitado não é multiplo de 5.");
            }
            Console.ReadKey();
        }
    }
}
