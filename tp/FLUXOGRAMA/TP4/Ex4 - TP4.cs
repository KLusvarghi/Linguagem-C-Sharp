using System;

namespace Ex4___AULA_2
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            double n1, n2, n3, media;
            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o terceiro número: ");
            n3 = Convert.ToDouble(Console.ReadLine());
            media = (n1 + n2 + n3) / 3;
            Console.Write("A média aritimética dos três números digitados é: " + media);
        }//Fim
    }
}
