using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            double num, raiz, quadrado;
            Console.WriteLine("Entrar com um numero: ");
            num = Convert.ToDouble(Console.ReadLine());
            raiz = Math.Sqrt(num); //retorna a raiz
            Console.WriteLine("Raiz é: " + raiz);
            quadrado = Math.Pow(num, 2);//retorna o quadrado
            Console.WriteLine("Quadrado é: " + quadrado);
            Console.ReadKey();
        }//fim
    }
}
