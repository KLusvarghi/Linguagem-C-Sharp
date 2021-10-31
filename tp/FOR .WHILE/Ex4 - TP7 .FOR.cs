/*
Criar um programa que permita o usuário entrar com vinte números, após o termino da digitação, 
mostrar na tela qual o maior e menor numero que o usuário digitou.
*/
using System;

namespace Ex4___AULA_8___FOR
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.SetCursorPosition(4, 2);

                Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                Console.SetCursorPosition(4, 3);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 4);
                Console.WriteLine("▓            FATEC - 2021              ▓");
                Console.SetCursorPosition(4, 5);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 6);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 7);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 8);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 9);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 10);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 11);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 12);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 13);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 14);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 15);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 16);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 17);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 18);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 19);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 20);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 21);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 22);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 23);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 24);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 25);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 26);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 27);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 28);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 29);
                Console.WriteLine("▓                                      ▓");
                Console.SetCursorPosition(4, 30);

                Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            double maior = 0;
            double menor = 10000;
            int i;
            int x = 6;
            for (i = 1; i <= 20; i++) {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(11, x);
                Console.Write("Digite o " +i+ "º número: ");
                x++;
				double num = Convert.ToDouble(Console.ReadLine());
				if (num > maior)
				{
					maior = num;
				}
				else if (num < menor)
				{
					menor = 0 + num;
				}
			}
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(8, 27);
            Console.WriteLine("O maior número digitado é: " + maior);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(8, 28);
            Console.WriteLine("O menor número digitado é: " + menor);
            Console.ReadKey();
		}//fim
	}
}
