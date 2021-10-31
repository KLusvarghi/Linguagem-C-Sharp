/*
Elabore um programa que calcule a equação de segundo grau utilizando a formula de Bhaskara.
OBS: O usuário deve entrar com ‘a’, ‘b’ e ‘c’ e devemos calcular o valor de ‘x1’ e ‘x2’.
• Formula:
• Delta= B²−4*a*c
• X= (−b±√Delta)/(2*a)
a= 2
b= 3
c= -5
*/
using System;

namespace Ex2___AULA_33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de 'A': ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor de 'B': ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor de 'C': ");
            double c = Convert.ToInt32(Console.ReadLine());
            double delta = Math.Pow(b, 2) - 4 * a * (c);
            //Console.WriteLine("o delta é:" + delta);
            Double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            Double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine("O valor de X1 é: " + x1);
            Console.WriteLine("O valor de X2 é: " + x2);
            Console.ReadKey();
        }
    }
}
