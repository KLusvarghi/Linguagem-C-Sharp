//Crie um programa e fluxograma que permita ao usuário entrar com dois números.
//Executar as quatro operações com esses dois números
//(Soma, Subtração, multiplicação, divisão). Não se esquecer de mostrar as respostas na tela.

using System;

namespace Ex2___AULA_2
{
    class Program
    {
        static void Main(string[] args)
        {//INICIO
            Double n1, n2, soma, div, sub, mult;
            Console.Write("Digite o primeiro número: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            soma = n1 + n2;
            div = n1 / n2;
            mult = n1 * n2;
            sub = n1 - n2;
            Console.WriteLine();
            Console.WriteLine("A SOMA de " +n1+ " e " +n2+ " é: " +soma);
            Console.WriteLine("A SUBTRAÇÃO de " + n1 + " e " + n2 + " é: " + sub);
            Console.WriteLine("A MULTIPLICAÇÃO de " + n1 + " e " + n2 + " é: " + mult);
            Console.WriteLine("A DIVISÃO de " + n1 + " e " + n2 + " é: " + div);
        }//FIM
    }
}
