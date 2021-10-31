//Crie um programa que permita o usuário digitar um numero qualquer. Imprimir na tela a tabuada deste numero.

using System;

namespace Ex1___AULA_8
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(4, 2);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("▓                               ▓");
            Console.SetCursorPosition(4, 4);
            Console.WriteLine("▓          FATEC - 2021         ▓");
            Console.SetCursorPosition(4, 5);
            Console.WriteLine("▓                               ▓");
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("▓                               ▓");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("▓                               ▓");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("▓                               ▓");
            Console.SetCursorPosition(4, 9);
            Console.WriteLine("▓                               ▓");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("▓                               ▓");
            Console.SetCursorPosition(4, 10);
            Console.WriteLine("▓                               ▓");
            Console.SetCursorPosition(4, 11);
            Console.WriteLine("▓                               ▓");
            Console.SetCursorPosition(4, 12);
            Console.WriteLine("▓                               ▓");
            Console.SetCursorPosition(4, 13);
            Console.WriteLine("▓                               ▓");
            Console.SetCursorPosition(4, 14);
            Console.WriteLine("▓                               ▓");
            Console.SetCursorPosition(4, 15);
            Console.WriteLine("▓                               ▓");
            Console.SetCursorPosition(4, 16);
            Console.WriteLine("▓                               ▓");
            Console.SetCursorPosition(4, 17);
            Console.WriteLine("▓                               ▓");
            Console.SetCursorPosition(4, 18);
            Console.WriteLine("▓                               ▓");
            Console.SetCursorPosition(4, 19);
            Console.WriteLine("▓                               ▓");
            Console.SetCursorPosition(4, 20);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(8, 6);
            Console.Write("Digite um numero: ");
            double num = Convert.ToDouble(Console.ReadLine());
            int x = 8;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            for (int c = 0; c<=10; c++){
                double mult = num * c;
                Console.SetCursorPosition(14, x);
                Console.WriteLine(num + " x " + c+ " = "+ mult);
                x++;
            }
            Console.ReadKey();
        }//fim
    }
}
