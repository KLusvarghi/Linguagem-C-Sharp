/*
Elabore um programa que receba via teclado quatro notas de um aluno. Calcular e exibir na tela a media 
aritmética dessas notas. Obs. A cada nota digitada, verificar se as mesmas estão no intervalo de 0 a 10. 
Perguntar se o usuário deseja continuar.
*/

using System;

namespace Ex2___AULA_7___DO_WHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            double med = 0;
            double nota;
            string resp = "s";
            int i = 1;
            int x = 0;
            do
            {
            inicio:
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Digite a " + i + "º nota: ");
                nota = Convert.ToDouble(Console.ReadLine());
                if (nota >= 0 && nota <= 10)
                {
                    med = med + nota;
                    x++;
                    i++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("O número digitado não está entre 0 á 10.");
                    Console.WriteLine("");
                    goto inicio;
                }
                if (i >= 1 && i <= 4)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.Write("Deseja continuar? [S/N] ");
                    resp = Console.ReadLine();
                    resp = resp.ToLower();
                }
            } while (i != 5 && resp == "s");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("A Média Aritimética das notas é: " + (med / x));
            Console.ReadKey();
        }
    }
}