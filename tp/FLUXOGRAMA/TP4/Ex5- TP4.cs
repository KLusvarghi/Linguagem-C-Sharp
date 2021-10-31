using System;

namespace Ex1___AULA_3
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            int num, ant;
            Console.Write("Digire um número: ");
            num = Convert.ToInt32(Console.ReadLine());
            ant = num - 1;
            Console.Write("O antecessor de " + num + " é " + ant);
        }//Fim
    }
}
