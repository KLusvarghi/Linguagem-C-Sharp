//Elabore um programa que exiba na tela uma sequencia de números naturais começando em I, terminando em F.

using System;

namespace Ex1___AULA_8___WHILE
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.Write("Digite um número: ");
			double num = Convert.ToDouble(Console.ReadLine());
			Console.ForegroundColor = ConsoleColor.Red;
			Console.Write("Digite outro número: ");
			double num2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("");
			int x = 3;
			if (num > num2)
			{
				while (num >= num2)
				{
					Console.SetCursorPosition(8, x);
					Console.ForegroundColor = ConsoleColor.DarkMagenta;
					Console.WriteLine("<"+num2+">");
					num2 = num2 + 1;
					x++;
				}
			}
            else {
				while (num2 >= num)
				{
					Console.SetCursorPosition(8, x);
					Console.ForegroundColor = ConsoleColor.DarkGreen;
					Console.WriteLine("<" + num + ">");
					num = num + 1;
					x++;
				}
			}
			Console.ReadKey();
		}//fim
    }
}
