/*
Ler um valor N e imprimir todos os valores inteiros entre 1 (inclusive) e N (inclusive). 
Considere que o N será sempre maior que ZERO.
*/
using System;

namespace Ex2___AULA_8___FOR
{
	class Program
	{
		static void Main(string[] args)
		{//inicio
			double i;
			inicio:
			Console.Write("Digite um número: ");
			double num = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("");
			for (i = 1; i <= num; i++)
			{
				if (num > 1)
				{
					Console.WriteLine("<" + i + ">");
					
				}
				else
				{
					Console.WriteLine("O valor Digitado é inválido.");
					goto inicio;
				}
			}
			Console.ReadKey();
		}//fim
	}
}