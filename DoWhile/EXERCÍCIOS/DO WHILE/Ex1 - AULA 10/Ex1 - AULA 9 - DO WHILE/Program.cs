/*
Crie um programa que, utilizando a estrutura “Do While”, permita que o usuário digite um numero,
este numero deve ser par, mostrar na tela o numero digitado. Não permitir que o usuário digite um numero que não seja par.
*/

using System;

namespace Ex1___AULA_9___DO_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int x;
            do
            {
                Console.Write("Digite um número: ");
                num = Convert.ToInt32(Console.ReadLine());
                x = 0;
                if (num % 2 == 0) {
                }
                else{
                    Console.WriteLine("valor incorreto.");
                    Console.ReadKey();
                    x++;
                }
                Console.Clear();
            } while (x == 1);
            Console.WriteLine("valor correto!");
            Console.WriteLine("Número digitado: "+num);
            Console.ReadKey();
        }
    }
}
