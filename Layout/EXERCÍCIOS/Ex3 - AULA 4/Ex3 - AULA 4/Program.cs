/*
Escreva um algoritmo para ler uma temperatura em graus Fahrenheit, calcular e escrever o valor 
correspondente em graus Celsius 
*/
using System;

namespace Ex3___AULA_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("║                                                                                     ║");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("║                                                                                     ║");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("║                                                                                     ║");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("║                                                                                     ║");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("║                                                                                     ║");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("║                                                                                     ║");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("║                                                                                     ║");
            Console.SetCursorPosition(3, 11);
            Console.WriteLine("║                                                                                     ║");
            Console.SetCursorPosition(3, 12);
            Console.WriteLine("║                                                                                     ║");
            Console.SetCursorPosition(3, 13);
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(18, 5);
            Console.Write("Digite a temperatura em graus Fahrenheit: ");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(18, 6);
            double Fahrenheit = Convert.ToDouble(Console.ReadLine());
            double Celsius = (Fahrenheit - 32) / 1.8;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.SetCursorPosition(6, 11);
            Console.Write("A temperatura de " + Fahrenheit + " ºF na escala de Celsius ficará: " + Celsius + "ºC");
            Console.ReadKey();
        }
    }
}
