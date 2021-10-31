/*
Crie um programa que permita que o usuário digite o valor das vendas que executou neste mês, imprimir na tela o
premio que ganhou por estas vendas de acordo com os critérios abaixo:

•Menor que R$ 1000,00 (Sem premio).
•Maior igual a R$ 1000,00 e menor que R$ 3000,00 (premio de R$ 150,00).
•Maior igual a R$ 3000,00 (premio de R$ 300,00). 
 */

using System;

namespace Ex1___AULA_7
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(4, 2);
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(4, 3);                
            Console.WriteLine("▓                  FATEC - 2021                  ▓");
            Console.SetCursorPosition(4, 4);
            Console.WriteLine("▓                                                ▓");
            Console.SetCursorPosition(4, 5);
            Console.WriteLine("▓                                                ▓");
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("▓                                                ▓");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("▓                                                ▓");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("▓                                                ▓");
            Console.SetCursorPosition(4, 9);
            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(9, 5);
            Console.Write("Digite o valor das vendas do mês: ");
            Double vendas = Convert.ToDouble(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.SetCursorPosition(16, 7);
            if (vendas < 1000){
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(21, 7);
                Console.WriteLine("[ Sem premio ]");
            }
            else if ((vendas>=1000) && (vendas<=3000)){
                Console.WriteLine("[ Prêmio de 150,00 reais ]");
            }
            else {
                Console.WriteLine("[ Prêmio de 300,00 reais ]");
            }
            Console.ReadKey();
        }//fim
    }
}
