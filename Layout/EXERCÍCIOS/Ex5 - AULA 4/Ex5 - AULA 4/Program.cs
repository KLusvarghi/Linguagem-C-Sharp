/*
Criar um programa que permita que o usuário digite um número, verificar se este número 
é maior que 20, se for maior mostrar na tela a metade do número digitado, caso seja menor 
20 mostrar o dobro do número digitado.
*/
using System;

namespace Ex5___AULA_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("╔════════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("║                                                                            ║");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("║                                                                            ║");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("║                                                                            ║");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("║                                                                            ║");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("║                                                                            ║");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("║                                                                            ║");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("║                                                                            ║");
            Console.SetCursorPosition(3, 11);
            Console.WriteLine("║                                                                            ║");
            Console.SetCursorPosition(3, 12);
            Console.WriteLine("║                                                                            ║");
            Console.SetCursorPosition(3, 13);
            Console.WriteLine("╚════════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(10, 6); 
            Console.Write("Digite um número: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(10, 7);
            double num = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(10, 10);
            if (num > 20)
            {
                num = num / 2;
                Console.Write("O número digitado é maior do que 20, então ele será " + num); 
            }
            else if ( num < 20)
            {
                num = num * 2;
                Console.Write("O número digitado é menor do que 20, então ele será " + num);
            }
            else
            {
                Console.Write("O número digitado é igual a 20");
            }
            Console.ReadKey();
        }
    }
}
