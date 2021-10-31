using System;

namespace Ex2___AULA_2_
{
    class Program
    {
        static void Main(string[] args)
        {//INICIO
            Double n1, n2, resp;
            Console.Write("Digite os dois número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            n2 = Convert.ToDouble(Console.ReadLine());
            resp = n1 + n2;
            Console.WriteLine("A SOMA é: " + resp);
            resp = n1 - n2;
            Console.WriteLine("A SUBTRAÇÃO é: " + resp);
            resp = n1 * n2;
            Console.WriteLine("A MULTIPLICAÇÃO é: " + resp);
            resp = n1 / n2;
            Console.WriteLine("A DIVISÃO de é: " + resp);
            Console.ReadKey();  
        }//FIM
    }
}
