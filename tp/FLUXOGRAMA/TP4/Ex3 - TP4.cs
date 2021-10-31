using System;

namespace Ex3___AULA_2
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            int ano, anoATU, idade;
            Console.Write("Digite o ano que você nasceu: ");
            ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o ano atual: ");
            anoATU = Convert.ToInt32(Console.ReadLine());
            idade = anoATU - ano;
            Console.WriteLine("Você tem " + idade + " anos.");
            Console.ReadKey();
        }//Fim
    }
}
