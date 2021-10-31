/*
Elabore um programa que crie o seguinte menu:
Formulas:
  1 – Baskara.
  2 – Força. (F = m * a)
  3 – Velocidade. (V = Vo + a*t)
*/

using System;

namespace Ex1___AULA_7
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
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
            Console.WriteLine("Opcão (1) - Baskara");
            Console.SetCursorPosition(8, 6);
            Console.WriteLine("Opcão (2) - Força");
            Console.SetCursorPosition(8, 7);
            Console.WriteLine("Opcão (3) - Velocidade");
            Console.SetCursorPosition(8, 9);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("Escolha uma opção:   [ ]");
            Console.SetCursorPosition(30, 9);
            int op = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            switch (op)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(8, 11);
                    Console.Write("Digite o valor de 'A': ");
                    double a = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(8, 12);
                    Console.Write("Digite o valor de 'B': ");
                    double b = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(8, 13);
                    Console.Write("Digite o valor de 'C': ");
                    double c = Convert.ToDouble(Console.ReadLine());
                    double delta = Math.Pow(b, 2) - 4 * a * (c);
                    Double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    Double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(15, 14);
                    Console.WriteLine("O valor de X1 é: " + x1);
                    Console.SetCursorPosition(15, 15);
                    Console.WriteLine("O valor de X2 é: " + x2);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(8, 11);
                    Console.Write("Digite o valor da Massa: ");
                    double mass = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(8, 12);
                    Console.Write("Digite o valor da Aceleração: ");
                    double acel = Convert.ToDouble(Console.ReadLine());
                    double forca = mass * acel;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(21, 14);
                    Console.WriteLine("A força é " +forca);
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(8, 11);
                    Console.Write("Digite a velocidade inicial: ");
                    double valoI = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(8, 12);
                    Console.Write("Digite a aceleração do corpo ");
                    double acelera = Convert.ToDouble(Console.ReadLine());
                    Console.SetCursorPosition(8, 13);
                    Console.Write("Digite o intervalo de tempo ");
                    double tempo = Convert.ToDouble(Console.ReadLine());
                    double velocidade = valoI + (acelera * tempo);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(17, 15);
                    Console.WriteLine("A velocidade é " +velocidade);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(18, 12);
                    Console.Write("OPÇÃO INVÁLIDA");
                    break;
            }
            Console.ReadKey();
        }//fim
    }
}
