using System;

namespace Ex2___AULA_3
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            Console.Write("Digite o valor de 'A': ");
            double a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor de 'B': ");
            double b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o valor de 'C': ");
            double c = Convert.ToInt32(Console.ReadLine());
            double delta = Math.Pow(b, 2) - 4 * a * (c);
            if (delta>0)
            {
                Double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                Double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("O valor de X1 é: " + x1);
                Console.WriteLine("O valor de X2 é: " + x2);
            }
            else
            {
                Console.WriteLine("Impossivel calcular com delta negativo");
            }
            Console.ReadKey();
        }//Fim
    }
}
