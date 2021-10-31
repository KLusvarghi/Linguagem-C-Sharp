/*
Crie um programa que, utilizando a estrutura “Do While”, permita que o usuário digite um numero,
este numero deve ser par, mostrar na tela o numero digitado. Não permitir que o usuário digite um numero que não seja par.
*/
using System;

namespace Ex1____AULA_10
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int i=1;
            double num;
            do
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite o "+x+"º número: ");
                num = Convert.ToDouble(Console.ReadLine());
                x++;
                if (num % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Número digitado: " + num);
                    Console.WriteLine("");
                }
                else
                {
                    i++;
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("  <valor inválido>");
                }
            } while (i == 1);
            Console.ReadKey();
        }
    }
}
