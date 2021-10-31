/*
Crie um programa no qual o usuário deverá informar três valores inteiros (segmentos de retas). 
O programa deverá informar se esses valores representam os lados de um triângulo.

Dica: Dados três segmentos de reta distintos, se a soma das medidas de dois deles é sempre maior que a
medida do terceiro, então, eles podem formar um triângulo.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2____AULA_12
{
    class Program
    {
        static void mold()
        {
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            int l = 3;
            Console.SetCursorPosition(6, l);
            Console.WriteLine("╔═════════════════════════════════════════╗");
            for (l = 4; l <= 12; l++)
            {
                Console.SetCursorPosition(6, l);
                Console.WriteLine("║                                         ║");
            }
            Console.SetCursorPosition(6, l);
            Console.WriteLine("╚═════════════════════════════════════════╝");
        }
        static bool triangulo(int l1, int l2, int l3)
        {
            bool retorno = false;
            if ((l1 < l2 + l3) && (l2 < l1 + l3) && (l3 < l1 + l2));{
                retorno = true;
            }
            return retorno;
        }
        static void Main(string[] args)
        {//inicio
            Console.Title = "Triângulo?";
            mold();
            int a, b, c;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(21, 5);
            Console.WriteLine("Fatec - 2021");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(9, 7);
            Console.Write("Digite o primeiro valor inteiro: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(9, 8);
            Console.Write("Digite o segundo valor inteiro: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(9, 9);
            Console.Write("Digite o terceiro valor inteiro: ");
            c = Convert.ToInt32(Console.ReadLine());
            bool resp = triangulo (a, b, c);
            if (resp == true) {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.SetCursorPosition(9, 7);
                Console.Write("Representa os lados de um triângulo");
            }
            else {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.SetCursorPosition(9, 7);
                Console.Write("Não representa os lados de um triângulo");
            }
            Console.ReadKey();
        }//fim
    }
}
