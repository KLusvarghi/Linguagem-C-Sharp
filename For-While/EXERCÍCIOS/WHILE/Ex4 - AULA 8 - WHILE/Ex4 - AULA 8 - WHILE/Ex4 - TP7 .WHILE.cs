/*
Escreva um programa que imprima as seguintes sequencias de números: (1, 1 2 3 4 5 6 7 8 9 10) 
(2, 1 2 3 4 5 6 7 8 9 10) (3, 1 2 3 4 5 6 7 8 9 10) (4, 1 2 3 4 5 6 7 8 9 10) e assim sucessivamente,
até que o primeiro número (antes da vírgula), também chegue a 10.
*/
using System;

namespace Ex4___AULA_8___WHILE
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(4, 2);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("▓                                ▓");
            Console.SetCursorPosition(4, 4);
            Console.WriteLine("▓         FATEC - 2021           ▓");
            Console.SetCursorPosition(4, 5);
            Console.WriteLine("▓                                ▓");
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("▓                                ▓");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("▓                                ▓");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("▓                                ▓");
            Console.SetCursorPosition(4, 9);
            Console.WriteLine("▓                                ▓");
            Console.SetCursorPosition(4, 10);
            Console.WriteLine("▓                                ▓");
            Console.SetCursorPosition(4, 11);
            Console.WriteLine("▓                                ▓");
            Console.SetCursorPosition(4, 12);
            Console.WriteLine("▓                                ▓");
            Console.SetCursorPosition(4, 13);
            Console.WriteLine("▓                                ▓");
            Console.SetCursorPosition(4, 14);
            Console.WriteLine("▓                                ▓");
            Console.SetCursorPosition(4, 15);
            Console.WriteLine("▓                                ▓");
            Console.SetCursorPosition(4, 16);
            Console.WriteLine("▓                                ▓");
            Console.SetCursorPosition(4, 17);
            Console.WriteLine("▓                                ▓");
            Console.SetCursorPosition(4, 18);
            Console.WriteLine("▓                                ▓");
            Console.SetCursorPosition(4, 19);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(11, 6);
            Console.WriteLine("A sequência ficará: ");
            int x = 1;
            int i = 8;
            while (x <= 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.SetCursorPosition(9, i);
                Console.WriteLine(x + ", " + "1 2 3 4 5 6 7 8 9 10");
                x++;
                i++;
            }
            Console.ReadKey();
        }//fim
    }
}
