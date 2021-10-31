/*
A prefeitura esta concedendo empréstimos a seus funcionários seguindo a regra de que a prestação 
não pode ser maior que 30% do valor do salário.
Criar um programa que permita a entrada do salário e da prestação do empréstimo, verificar se
a prestação digitada corresponde a regra de empréstimo descrita acima.
*/
using System;

namespace Ex7___AULA_4
{
    class Program
    {
        static void Main(string[] args)
        {
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
            Console.SetCursorPosition(20, 11);
            if (emprestimo < salario30)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Emprestimo concedido");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Emprestimo não concedido");
            }
            Console.ReadKey();
        }
    }
}
