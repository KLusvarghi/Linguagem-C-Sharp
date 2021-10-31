//Elaborar um programa e fluxograma para calcular a média aritmética de três números digitados pelo usuário.

using System;

namespace Ex4___AULA_2
{
    class Program
    {
        static void Main(string[] args)
        {//INICIO
            int n1, n2, n3;
            double media;
            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            n3 = Convert.ToInt32(Console.ReadLine());
            media = (n1 + n2 + n3) / 3;
            Console.Write("A média aritimética dos três números digitados é: " + media);
        }//FIM
    }
}
