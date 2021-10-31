/*
Crie um programa que permite que o usuário digite o valor de um numero qualquer, verificar se o numero é múltiplo 
de 3 e de 7 ao mesmo tempo, caso seja imprimir na tela “Múltiplo de 3 e 7”, caso não imprimir “Não é múltiplo”.
*/
using System;

namespace Ex2___AULA_7
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(4, 2);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("▓               FATEC - 2021            ▓");
            Console.SetCursorPosition(4, 4);
            Console.WriteLine("▓                                       ▓");
            Console.SetCursorPosition(4, 5);
            Console.WriteLine("▓                                       ▓");
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("▓                                       ▓");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("▓                                       ▓");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("▓                                       ▓");
            Console.SetCursorPosition(4, 9);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(9, 5);
            Console.Write("Digite um valor: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(9, 7);
            if ((num % 3 == 0) && (num % 7 == 0))
            {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Número é últiplo de 3 e 7");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Número não é múltiplo de 3 e 7");
            }
            Console.ReadKey();
        }//fim
    }
}
