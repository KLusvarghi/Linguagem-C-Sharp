using System;

namespace Ex1___AULA_4
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            int i;
            double minimo, salario, maior;
            maior = 0;
            i = 0;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("╔═════════════════════════════════════════════╗");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("║                                             ║");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("║                                             ║");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("║                                             ║");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("║                                             ║");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("║                                             ║");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("║                                             ║");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("║                                             ║");
            Console.SetCursorPosition(3, 11);
            Console.WriteLine("║                                             ║");
            Console.SetCursorPosition(3, 12);
            Console.WriteLine("║                                             ║");
            Console.SetCursorPosition(3, 13);
            Console.WriteLine("╚═════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("Digite o valor do seu salário: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(10, 6);
            salario = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(10, 7);
            Console.WriteLine("Digite o valor do salário mínimo: ");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(10, 8);
            minimo = Convert.ToDouble(Console.ReadLine());
            while (salario > maior) 
            {
                maior = maior + minimo;
                i = i + 1;
            }
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Você recebe " + i + " salarios minimos");
            Console.ReadKey();
        }//Fim
    }
}
