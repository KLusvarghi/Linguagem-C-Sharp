/*
Crie um algoritmo no qual o usuário poderá escolher qual operação matemática ele poderá executar, adição,
subtração, multiplicação e divisão. Como regra você deverá implementar funções que retornam os resultados 
das operações matemáticas.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1___AULA_9
{
    class Program
    {
        static void mold()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            int l = 3;
            Console.SetCursorPosition(6, l);
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            for (l = 4; l <= 19; l++)
            {
                Console.SetCursorPosition(6, l);
                Console.WriteLine("▓                                         ▓");
            }
            Console.SetCursorPosition(6, l);
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
        }

        static double soma(double n1, double n2)
        {
            double resul = n1 + n2;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(21, 18);
            Console.WriteLine("A soma é: " + resul);
            return 0;
        }

        static double subtracao(double n1, double n2)
        {
            double resul = n1 - n2;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(18, 18);
            Console.WriteLine("A subitração é: " + resul);
            return 0;
        }

        static double mult(double n1, double n2)
        {
            double resul = n1 * n2;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(16, 18);
            Console.WriteLine("A multiplicação é: " + resul);
            return 0;
        }

        static double div(double n1, double n2)
        {
            double resul = n1 / n2;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(19, 18);
            resul = Math.Round(resul, 2); 
            Console.WriteLine("A divisão é: " + resul);
            return 0;
        }

        static void Main(string[] args)
        {//inicio
            Console.Title = "Operações Matemáticas";
            mold();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(20, 5);
            Console.WriteLine("Fatec - 2021");
            inicio:
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(19, 7);
            Console.WriteLine("(1) Soma ");
            Console.SetCursorPosition(19, 8);
            Console.WriteLine("(2) Subtração ");
            Console.SetCursorPosition(19, 9);
            Console.WriteLine("(3) Multiplicação ");
            Console.SetCursorPosition(19, 10);
            Console.WriteLine("(4) Divisão");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(9, 12);
            Console.WriteLine("Digite uma opção de operação: [ ]");
            Console.SetCursorPosition(40, 12);
            int op = Convert.ToInt32(Console.ReadLine());
            double a;
            double b;
            switch (op)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(9, 15);
                    Console.Write("Digite o primeiro número: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(9, 16);
                    Console.Write("Digite o segundo número: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    soma(a, b);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(9, 15);
                    Console.Write("Digite o primeiro número: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(9, 16);
                    Console.Write("Digite o segundo número: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    subtracao(a, b);
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(9, 15);
                    Console.Write("Digite o primeiro número: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(9, 16);
                    Console.Write("Digite o segundo número: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    mult(a, b);
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(9, 15);
                    Console.Write("Digite o primeiro número: ");
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(9, 16);
                    Console.Write("Digite o segundo número: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    div(a, b);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(19, 13);
                    Console.WriteLine("Opção inválida.");
                    goto inicio;
            }
            Console.ReadKey();
        }//fim
    }
}