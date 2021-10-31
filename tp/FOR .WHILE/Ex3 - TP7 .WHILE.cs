//Ler 10 valores e escrever quantos desses valores lidos são NEGATIVOS.

using System;

namespace Ex3___AULA_8___WHILE
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

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            int y = 6;
            int x = 0;
            int i = 1;
            while (i <= 10)
			{
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(12, y);
                Console.Write("Digite o " + i + "º valor: ");
				Double valor = Convert.ToDouble(Console.ReadLine());
                y++;
				i = i + 1;
				if (valor < 0)
				{
					x = x + 1;
				}
			}
			if (x <= 0) {
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.SetCursorPosition(9, 17);
                Console.WriteLine("Não tem nenhum valor negativo.");
			}
            else {
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.SetCursorPosition(9, 17);
                Console.WriteLine("Existem " + x + " valores negativos.");
			}
			Console.ReadKey();
		}//fim
    }
}
