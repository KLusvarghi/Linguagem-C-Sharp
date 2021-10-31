/*Elaborar um programa que permita que o usuário escreva seu nome completo. Mostrar na tela:
• Nome e o sobrenome separadamente.
• O conteúdo da string do caractere cinco ao dez.
• Substituir todos os caracteres ‘a’ pelo ‘o’
*/
using System;

namespace Ex3___AULA_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string completo, prinome, sobrenome;
            Console.Write("Digite seu nome completo: ");
            completo = Console.ReadLine();
            Console.WriteLine("Nome completo: " + completo);

            string[] nomeseparado = completo.Split(' ');
            prinome = nomeseparado[0];
            sobrenome = nomeseparado[nomeseparado.Length - 1];

            Console.WriteLine("Nome: " +prinome);
            Console.WriteLine("sobrenome: " +sobrenome);
            Console.WriteLine("substituindo: " + completo.ToLower().Replace("a", "o"));
            Console.ReadKey();
        }
    }
}

