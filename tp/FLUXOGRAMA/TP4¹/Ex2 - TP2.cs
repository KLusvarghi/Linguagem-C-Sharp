using System;

namespace Ex2___AULA_4
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2, 3);
            Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("║                                                                               ║");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("║                                                                               ║");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("║                                                                               ║");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("║                                                                               ║");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("║                                                                               ║");
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("║                                                                               ║");
            Console.SetCursorPosition(2, 10);
            Console.WriteLine("║                                                                               ║");
            Console.SetCursorPosition(2, 11);
            Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(18, 5);
            Console.Write("Digite a temperatura em graus Celsius: ");
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(18, 6);
            double celsius = Convert.ToDouble(Console.ReadLine());
            double kelvin = celsius + 273;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(10, 9);
            Console.Write("A temperatura de "+ celsius +" Celsius na escala de Kelvin ficará: "+kelvin+" kelvin");
            Console.ReadKey();
        }//Fim
    }
}
