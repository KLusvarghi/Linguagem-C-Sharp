//Escreva um código que leia um número do teclado até que encontre um número menor ou igual a 1.

using System;

namespace Ex___AULA_10___DO
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            int i = 1;
            inicio:
            do{
                try
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("Digite o " + i + "º número: ");
                    num = Convert.ToDouble(Console.ReadLine());
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Valor incorreto!");
                    Console.WriteLine("");
                    goto inicio;
                }
                i++;
            } while (num > 1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("  <Fim do programa>");
            Console.ReadKey();
        }
    }
}
