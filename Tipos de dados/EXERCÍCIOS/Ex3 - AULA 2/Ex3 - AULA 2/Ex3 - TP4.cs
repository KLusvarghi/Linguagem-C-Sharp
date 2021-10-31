// Desenvolva um programa e fluxograma para calcular a idade de uma pessoa, entrando com o ano de nascimento e ano atual.

using System;

namespace Ex3___AULA_2
{
    class Program
    {
        static void Main(string[] args)
        {//INICIO
            int ano, anoATU, idade;
            Console.Write("Digite o ano que você nasceu: ");
            ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o ano atual: ");
            anoATU = Convert.ToInt32(Console.ReadLine());
            idade = anoATU - ano;
            Console.WriteLine("Você tem " + idade + " anos.");
            Console.ReadKey();
        }//FIM
    }
}
