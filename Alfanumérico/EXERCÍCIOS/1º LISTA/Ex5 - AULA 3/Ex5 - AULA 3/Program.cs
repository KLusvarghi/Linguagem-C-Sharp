//Escreva um código para ler um valor (do teclado) e escrever (na tela) o seu antecessor.

using System;

namespace Ex1___AULA_3
{
    class Program
    {
        static void Main(string[] args)
        {//INICIO
            int num, ant;
            Console.Write("Digire um número: ");
            num = Convert.ToInt32(Console.ReadLine());
            ant = num - 1;
            Console.Write("O antecessor de " + num + " é " + ant);
        }//FIM
    }
}
