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
            string completo, prinome, sobrenome, parte, substi;
            Console.Write("Digite seu nome completo: ");
            completo = Console.ReadLine();
            Console.WriteLine("Nome completo: "+completo);
            int posicao = completo.IndexOf(" ");
            prinome = completo.Substring(0, posicao);
            sobrenome = completo.Substring(posicao);
            Console.WriteLine("Nome: "+prinome);
            Console.WriteLine("Sobrenome:" +sobrenome);
            parte = completo.Substring(5, 10);
            Console.WriteLine("A parte quebrada ficará: " +parte);
            completo = completo.ToLower();
            substi = completo.Replace("a", "o");
            Console.WriteLine("Substituindo o 'a' pelo 'o': " +substi);
            Console.ReadKey();
        }
    }
}
