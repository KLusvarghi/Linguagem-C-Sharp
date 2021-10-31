/*
Uma empresa concederá um aumento de salário aos seus funcionários, variável de acordo com o cargo, conforme a tabela abaixo.
Programa que lê o salário e o código do cargo de um funcionário e calcula o novo salário.
Se o cargo do funcionário não estiver na tabela, ele recebe 40% de aumento.

 Código    Cargo       Aumento

 1        Gerente        10%

 2        Analista       20%

3         Técnico        30%

•No final é mostrado o salário antigo, o novo salário e a diferença.
*/

using System;

namespace Ex3___AULA_7
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.SetCursorPosition(4, 2);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("▓                                       ▓");
            Console.SetCursorPosition(4, 4);
            Console.WriteLine("▓              FATEC - 2021             ▓");
            Console.SetCursorPosition(4, 5);
            Console.WriteLine("▓                                       ▓");
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("▓                                       ▓");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("▓                                       ▓");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("▓                                       ▓");
            Console.SetCursorPosition(4, 9);
            Console.WriteLine("▓                                       ▓");
            Console.SetCursorPosition(4, 10);
            Console.WriteLine("▓                                       ▓");
            Console.SetCursorPosition(4, 11);
            Console.WriteLine("▓                                       ▓");
            Console.SetCursorPosition(4, 12);
            Console.WriteLine("▓                                       ▓");
            Console.SetCursorPosition(4, 13);
            Console.WriteLine("▓                                       ▓");
            Console.SetCursorPosition(4, 14);
            Console.WriteLine("▓                                       ▓");
            Console.SetCursorPosition(4, 15);
            Console.WriteLine("▓                                       ▓");
            Console.SetCursorPosition(4, 16);
            Console.WriteLine("▓                                       ▓");
            Console.SetCursorPosition(4, 17);
            Console.WriteLine("▓                                       ▓");
            Console.SetCursorPosition(4, 18);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.SetCursorPosition(8, 6);
            Console.WriteLine(" Código      Cargo      Aumento");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.SetCursorPosition(8, 7);
            Console.WriteLine("  (1)       Gerente      10%");
            Console.SetCursorPosition(8, 8);
            Console.WriteLine("  (2)       Analista     20%");
            Console.SetCursorPosition(8, 9);
            Console.WriteLine("  (3)       Técnico      30%");
            Console.SetCursorPosition(14, 11);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write("Escolha um código: [ ]");
            Console.SetCursorPosition(34, 11);
            int op = Convert.ToInt32(Console.ReadLine());
            double salario;
            double porc;
            double novosal;
            double dif;
            switch (op)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(8, 13);
                    Console.Write("Digite o seu salário: ");
                    salario = Convert.ToDouble(Console.ReadLine());
                    porc = (salario * 10) / 100;
                    novosal = salario + porc;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(8, 14);
                    Console.WriteLine("O salário antigo é: "+salario);
                    Console.SetCursorPosition(8, 15);
                    Console.WriteLine("O novo salário é: " + novosal);
                    Console.SetCursorPosition(8, 16);
                    dif = novosal - salario;
                    dif = Math.Floor(dif);
                    Console.WriteLine("A diferença dos salários é: " + dif);
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(8, 13);
                    Console.Write("Digite o seu salário: ");
                    salario = Convert.ToDouble(Console.ReadLine());
                    porc = (salario * 20) / 100;
                    novosal = salario + porc;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(8, 14);
                    Console.WriteLine("O salário antigo é: " + salario);
                    Console.SetCursorPosition(8, 15);
                    Console.WriteLine("O novo salário é: " + novosal);
                    Console.SetCursorPosition(8, 16);
                    dif = novosal - salario;
                    dif = Math.Floor(dif);
                    Console.WriteLine("A diferença dos salários é: " + dif);
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.SetCursorPosition(8, 13);
                    Console.Write("Digite o seu salário: ");
                    salario = Convert.ToDouble(Console.ReadLine());
                    porc = (salario * 30) / 100;
                    novosal = salario + porc;
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.SetCursorPosition(8, 14);
                    Console.WriteLine("O salário antigo é: " + salario);
                    Console.SetCursorPosition(8, 15);
                    Console.WriteLine("O novo salário é: " + novosal);
                    Console.SetCursorPosition(8, 16);
                    dif = novosal - salario;
                    dif = Math.Floor(dif);
                    Console.WriteLine("A diferença dos salários é: " + dif);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.SetCursorPosition(17, 12);
                    Console.WriteLine("Código inválido.");
                    break;
            }
            Console.ReadKey();
        }//fim
    }
}
