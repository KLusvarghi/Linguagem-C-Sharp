using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo2
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            double n1, n2, r;
            Console.Write("Digite um numero: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite um numero: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            r = n1 + n2;
            Console.WriteLine("A soma é: " + r);
            Console.ReadKey();
        }//fim
    }
}
