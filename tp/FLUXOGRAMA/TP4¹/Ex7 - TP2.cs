using System;

namespace Ex7___AULA_4
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(3, 3);
            Console.WriteLine("╔═════════════════════════════════════════════════════════╗");
            Console.SetCursorPosition(3, 4);
            Console.WriteLine("║                                                         ║");
            Console.SetCursorPosition(3, 5);
            Console.WriteLine("║                                                         ║");
            Console.SetCursorPosition(3, 6);
            Console.WriteLine("║                                                         ║");
            Console.SetCursorPosition(3, 7);
            Console.WriteLine("║                                                         ║");
            Console.SetCursorPosition(3, 8);
            Console.WriteLine("║                                                         ║");
            Console.SetCursorPosition(3, 9);
            Console.WriteLine("║                                                         ║");
            Console.SetCursorPosition(3, 10);
            Console.WriteLine("║                                                         ║");
            Console.SetCursorPosition(3, 11);
            Console.WriteLine("║                                                         ║");
            Console.SetCursorPosition(3, 12);
            Console.WriteLine("║                                                         ║");
            Console.SetCursorPosition(3, 13);
            Console.WriteLine("╚═════════════════════════════════════════════════════════╝");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(9, 5);
            Console.Write("Digite o valor do seu salário: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(9, 6);
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.SetCursorPosition(9, 7);
            Console.Write("Digite o valor da prestação do empréstimo: ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(9, 8);
            double emprestimo = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine(emprestimo);
            double salario30 = (salario * 10) / 30;
            //Console.WriteLine(salario30);
            if (emprestimo < salario30)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(20, 11);
                Console.Write("Emprestimo concedido");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(20, 11);
                Console.Write("Emprestimo não concedido");
            }
            Console.ReadKey();
        }//Fim
    }
}
