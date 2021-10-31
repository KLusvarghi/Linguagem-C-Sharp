//Desenvolva um programa que permita a entrada do nome do usuário e exiba na tela.

using System;
namespace Ex._1___AULA_2
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            string nom;
            Console.Write("Digite seu nome: ");
            nom = Console.ReadLine();
            Console.Write("Seja bem vindo ao meu mundo " + nom);
            Console.ReadKey();
        }//fim
    }
}
