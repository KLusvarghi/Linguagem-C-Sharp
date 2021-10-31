/*
Faça um programa para ler: a descrição do produto (nome), a quantidade adquirida e o preço unitário. 
Calcular e escrever o total (total = quantidade adquirida * preço unitário), o desconto e o total a pagar 
(total a pagar = total - desconto), sabendo-se que:

 - Se quantidade <= 5 o desconto será de 2%
 - Se quantidade > 5 e quantidade <=10 o desconto será de 3%
 - Se quantidade > 10 o desconto será de 5%
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

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.SetCursorPosition(4, 3);
            Console.WriteLine("▓               FATEC - 2021                  ▓");
            Console.SetCursorPosition(4, 4);
            Console.WriteLine("▓                                             ▓");
            Console.SetCursorPosition(4, 5);
            Console.WriteLine("▓                                             ▓");
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("▓                                             ▓");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("▓                                             ▓");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("▓                                             ▓");
            Console.SetCursorPosition(4, 9);
            Console.WriteLine("▓                                             ▓");
            Console.SetCursorPosition(4, 10);
            Console.WriteLine("▓                                             ▓");
            Console.SetCursorPosition(4, 11);
            Console.WriteLine("▓                                             ▓");
            Console.SetCursorPosition(4, 12);
            Console.WriteLine("▓                                             ▓");
            Console.SetCursorPosition(4, 13);

            Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(8, 5);
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine();
            Console.SetCursorPosition(8, 6);
            Console.Write("Digite a quantidade adquirida: ");
            double qtd = Convert.ToDouble(Console.ReadLine());
            Console.SetCursorPosition(8, 7);
            Console.Write("Digite o preço unitário: ");
            double preco = Convert.ToDouble(Console.ReadLine());
            double tot = qtd * preco;
            double desc = 0;
            double totpg;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            if (qtd <= 5)
            {
                desc = tot * 0.02;
                totpg = tot - desc;
                Console.SetCursorPosition(8, 9);
                Console.WriteLine("Nome do produto: " + nome);
                Console.SetCursorPosition(8, 10);
                Console.WriteLine("Preço total de: R$" + tot);
                Console.SetCursorPosition(8, 11);
                Console.WriteLine("Com esconto de 2% ficará: R$" + totpg);

            }
            else if ((qtd > 5) && (qtd <= 10))
            {
                desc = tot * 0.03;
                totpg = tot - desc;
                Console.SetCursorPosition(8, 9);
                Console.WriteLine("Nome do produto: " + nome);
                Console.SetCursorPosition(8, 10);
                Console.WriteLine("Preço total de: R$" + tot);
                Console.SetCursorPosition(8, 11);
                Console.WriteLine("Com esconto de 3% ficará: R$" + totpg);
            }
            else
            {
                desc = tot * 0.05;
                totpg = tot - desc;
                Console.SetCursorPosition(8, 9);
                Console.WriteLine("Nome do produto: " + nome);
                Console.SetCursorPosition(8, 10);
                Console.WriteLine("Preço total de: R$" + tot);
                Console.SetCursorPosition(8, 11);
                Console.WriteLine("Com esconto de 5% ficará: R$" + totpg);
            }
            Console.ReadKey();
        }//fim
    }
}
