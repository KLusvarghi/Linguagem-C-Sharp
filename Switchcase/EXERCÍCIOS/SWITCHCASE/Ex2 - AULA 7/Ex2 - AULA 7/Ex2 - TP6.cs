/*
Desenvolva uma calculadora, onde será necessário entrar com a operação, primeiro e segundo valor, exiba o resultado na tela.
*/
using System;

namespace Ex2___AULA_7
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            Double n1, n2;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(4, 2);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("▓               FATEC - 2021              ▓");
            Console.SetCursorPosition(4, 4);
            Console.WriteLine("▓                                         ▓");
            Console.SetCursorPosition(4, 5);
            Console.WriteLine("▓                                         ▓");
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("▓                                         ▓");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("▓                                         ▓");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("▓                                         ▓");
            Console.SetCursorPosition(4, 9);
            Console.WriteLine("▓                                         ▓");
            Console.SetCursorPosition(4, 10);
            Console.WriteLine("▓                                         ▓");
            Console.SetCursorPosition(4, 11);
            Console.WriteLine("▓                                         ▓");
            Console.SetCursorPosition(4, 12);
            Console.WriteLine("▓                                         ▓");
            Console.SetCursorPosition(4, 13);
            Console.WriteLine("▓                                         ▓");
            Console.SetCursorPosition(4, 14);
            Console.WriteLine("▓                                         ▓");
            Console.SetCursorPosition(4, 15);
            Console.WriteLine("▓                                         ▓");
            Console.SetCursorPosition(4, 16);
            Console.WriteLine("▓                                         ▓");
            Console.SetCursorPosition(4, 17);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(8, 5);
            Console.WriteLine("(1) Soma ");
            Console.SetCursorPosition(8, 6);
            Console.WriteLine("(2) Subtração ");
            Console.SetCursorPosition(8, 7);
            Console.WriteLine("(3) Multiplicação ");
            Console.SetCursorPosition(8, 8);
            Console.WriteLine("(4) Divisão");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(8, 10);
            Console.Write("Escolha uma tipo de calculo: [ ]");
            Console.SetCursorPosition(38, 10);
            int op = Convert.ToInt32(Console.ReadLine());
            switch (op)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(8, 12);
                    Console.Write("Digite o 1º número: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(8, 13);
                    Console.Write("Digite o 2º número: ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    double soma = n1 + n2;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(17, 15);
                    Console.WriteLine("A soma ficará: "+soma);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(8, 12);
                    Console.Write("Digite o 1º número: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(8, 13);
                    Console.Write("Digite o 2º número: ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    double sub = n1 - n2;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(15, 15);
                    Console.WriteLine("A subtração ficará: " + sub);
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(8, 12);
                    Console.Write("Digite o 1º número: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(8, 13);
                    Console.Write("Digite o 2º número: ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    double mult = n1 * n2;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(13, 15);
                    Console.WriteLine("A multiplicação ficará: " + mult);
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(8, 12);
                    Console.Write("Digite o 1º número: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.SetCursorPosition(8, 13);
                    Console.Write("Digite o 2º número: ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    double div = n1 / n2;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(14, 15);
                    Console.WriteLine("A divisão ficará: " + div);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(18, 13);
                    Console.WriteLine("Opção inválida.");
                    break;
            }
            Console.ReadKey();
        }//fim
    }
}
