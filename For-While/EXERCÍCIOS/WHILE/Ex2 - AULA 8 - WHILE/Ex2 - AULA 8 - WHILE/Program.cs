//Faça um algoritmo que exiba quantas pessoas possuem mais de 18 anos. O algoritmo deverá ler a idade de 10 pessoas.

using System;

namespace Ex2___AULA_8___WHILE
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            int i = 1;
            int x = 0;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(4, 2);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("▓                                           ▓");
            Console.SetCursorPosition(4, 4);
            Console.WriteLine("▓                FATEC - 2021               ▓");
            Console.SetCursorPosition(4, 5);
            Console.WriteLine("▓                                           ▓");
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("▓                                           ▓");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("▓                                           ▓");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("▓                                           ▓");
            Console.SetCursorPosition(4, 9);
            Console.WriteLine("▓                                           ▓");
            Console.SetCursorPosition(4, 10);
            Console.WriteLine("▓                                           ▓");
            Console.SetCursorPosition(4, 11);
            Console.WriteLine("▓                                           ▓");
            Console.SetCursorPosition(4, 12);
            Console.WriteLine("▓                                           ▓");
            Console.SetCursorPosition(4, 13);
            Console.WriteLine("▓                                           ▓");
            Console.SetCursorPosition(4, 14);
            Console.WriteLine("▓                                           ▓");
            Console.SetCursorPosition(4, 15);
            Console.WriteLine("▓                                           ▓");
            Console.SetCursorPosition(4, 16);
            Console.WriteLine("▓                                           ▓");
            Console.SetCursorPosition(4, 17);
            Console.WriteLine("▓                                           ▓");
            Console.SetCursorPosition(4, 18);
            Console.WriteLine("▓                                           ▓");
            Console.SetCursorPosition(4, 19);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            int y = 6;
            while (i <= 10) {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(10, y);
                Console.Write("Digite a idade da " + i + "º pessoa: ");
                double idade = Convert.ToDouble(Console.ReadLine());
                y++;
                i++;
                if (idade > 18)
                {
                    x = x + 1;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.SetCursorPosition(9, 17);
            Console.WriteLine("Tem '" + x + "' pessoas com mais de 18 anos.");
            Console.ReadKey();
        }//fim
    }
}
