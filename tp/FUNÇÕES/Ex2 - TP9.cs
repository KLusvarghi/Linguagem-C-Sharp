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

namespace Ex2___AULA_12
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
        static void triangulo (int n1, int n2, int n3) {
            if (n1 + n2 > n3){
                if (n1 + n3 > n2){
                    if (n2 + n3 > n1){
                       Console.ForegroundColor = ConsoleColor.DarkYellow;
                       Console.SetCursorPosition(15, 11);
                       Console.WriteLine("Representam um Triângulo");
                     }
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(14, 11);
                Console.WriteLine("Não representam um Triângulo");
            }            
            return;
        }
        static void Main(string[] args)
        {//inicio
            Console.Title = "Triângulo?";
            mold();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.SetCursorPosition(21, 5);
            Console.WriteLine("Fatec - 2021");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(9, 7);
            Console.Write("Digite o primeiro valor inteiro: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(9, 8);
            Console.Write("Digite o segundo valor inteiro: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.SetCursorPosition(9, 9);
            Console.Write("Digite o terceiro valor inteiro: ");
            int c = Convert.ToInt32(Console.ReadLine());
            triangulo(a, b, c);
            Console.ReadKey();
        }//fim
    }
}