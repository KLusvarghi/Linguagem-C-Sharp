/*
Faça um programa para ler as 3 notas. Calcular a média de aproveitamento, usando a fórmula abaixo e escrever 
o conceito do aluno de acordo com a tabela de conceitos mais abaixo:

AP = 25%
TP = 25 %
P  = 50%
*/
using System;

namespace Ex4___AULA_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(4, 2);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("▓          FATEC - 2021        ▓");
            Console.SetCursorPosition(4, 4);
            Console.WriteLine("▓                              ▓");
            Console.SetCursorPosition(4, 5);
            Console.WriteLine("▓                              ▓");
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("▓                              ▓");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("▓                              ▓");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("▓                              ▓");
            Console.SetCursorPosition(4, 9);
            Console.WriteLine("▓                              ▓");
            Console.SetCursorPosition(4, 10);
            Console.WriteLine("▓                              ▓");
            Console.SetCursorPosition(4, 11);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(9, 5);
            Console.Write("Digite a 1º nota: ");
            double n1 = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(9, 6);
            Console.Write("Digite a 2º nota: ");
            double n2 = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(9, 7);
            Console.Write("Digite a 3º nota: ");
            double n3 = Convert.ToDouble(Console.ReadLine());
            double media = (n1 + n2 + n3) / 3;
            double medp = (n1 * 2.5) + (n2 * 2.5) + (n3 * 5);

            Console.SetCursorPosition(15, 9);
            if (media >= 9)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Conceito A");
            }
            else if ((media >= 7.5) && (media < 9))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Conceito B");
            }
            else if ((media >= 6) && (media < 7.5))
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Conceito C");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Conceito D");
            }
            Console.ReadKey();
        }
    }
}
