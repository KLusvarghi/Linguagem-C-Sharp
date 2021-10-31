/*
Faça um código em C# que leia a idade de uma pessoa expressa em anos, meses e dias e escreva a
idade dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e mês com 30 dias.
*/
using System;

namespace Ex7___AULA_3
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            int dia, mes, ano, totd;
            Console.Write("Digite quantos anos você tem: ");
            ano = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite quantos meses fazem desde o seu ultimo aniversário: ");
            mes = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite quantos dias fazem depois que completou mais um mês de vida: ");
            dia = Convert.ToInt32(Console.ReadLine());
            totd = (ano * 365) + (mes * 30) + dia;
            Console.Write("Você viveu " + totd + " dias na sua vida toda!");
        }//fim
    }
}
