// Crie um programa que permita que o usuário digite 10 números, some apenas os números digitados maiores do que 10.

using System;

namespace Ex3___AULA_8___FOR
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
			double soma = 0;
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(4, 2);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("▓                                               ▓");
            Console.SetCursorPosition(4, 4);
            Console.WriteLine("▓                  FATEC - 2021                 ▓");
            Console.SetCursorPosition(4, 5);
            Console.WriteLine("▓                                               ▓");
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("▓                                               ▓");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("▓                                               ▓");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("▓                                               ▓");
            Console.SetCursorPosition(4, 9);
            Console.WriteLine("▓                                               ▓");
            Console.SetCursorPosition(4, 10);
            Console.WriteLine("▓                                               ▓");
            Console.SetCursorPosition(4, 11);
            Console.WriteLine("▓                                               ▓");
            Console.SetCursorPosition(4, 12);
            Console.WriteLine("▓                                               ▓");
            Console.SetCursorPosition(4, 13);
            Console.WriteLine("▓                                               ▓");
            Console.SetCursorPosition(4, 14);
            Console.WriteLine("▓                                               ▓");
            Console.SetCursorPosition(4, 15);
            Console.WriteLine("▓                                               ▓");
            Console.SetCursorPosition(4, 16);
            Console.WriteLine("▓                                               ▓");
            Console.SetCursorPosition(4, 17);
            Console.WriteLine("▓                                               ▓");
            Console.SetCursorPosition(4, 18);
            Console.WriteLine("▓                                               ▓");
            Console.SetCursorPosition(4, 19);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            int x = 6;
            for (int i = 1; i <= 10; i++){
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(17, x);
                Console.Write("Digite o " +i+ "º número: ");
                x++;
                double num = Convert.ToDouble(Console.ReadLine());
				if (num > 10)
				{
					soma = soma + num;
				}
			}
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(7, 17);
            Console.WriteLine("A soma dos números maiores que 10 é: " + soma);
			Console.ReadKey();
		}//fim
    }
}
