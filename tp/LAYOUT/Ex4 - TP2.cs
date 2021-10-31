using System;

namespace Ex4___AULA_4
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("╔═════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("║                                                                     ║");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("║                                                                     ║");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("║                                                                     ║");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("║                                                                     ║");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("║                                                                     ║");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("║                                                                     ║");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("║                                                                     ║");
            Console.SetCursorPosition(3, 11);
            Console.WriteLine("║                                                                     ║");
            Console.SetCursorPosition(3, 12);
            Console.WriteLine("║                                                                     ║");
            Console.SetCursorPosition(3, 13);
            Console.WriteLine("╚═════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(24, 5);
            Console.Write("Digite seu peso em kg: ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(24, 6);
            double peso = Convert.ToDouble(Console.ReadLine());
            double peso10 = (peso * 10) / 100;
            peso = peso + peso10;
            double grama = peso * 1000;
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(10, 10);
            Console.Write("O peso com acrescimo de 10% ficará em gramas: "+  grama +"g");
            Console.ReadKey();
        }//Fim
    }
}
