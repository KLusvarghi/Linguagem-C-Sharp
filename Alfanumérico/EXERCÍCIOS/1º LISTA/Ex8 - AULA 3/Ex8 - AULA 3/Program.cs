//Faça um código em C# que leia três notas de um aluno, calcule e escreva a média final deste aluno.
//Considerar que a média é ponderada e que o peso das notas é 2, 3 e 5.

using System;

namespace Ex3___AULA_3
{
    class Program
    {
        static void Main(string[] args)
        {//INICIO
            double n1, n2, n3, medp;
            Console.Write("Digite o valor da primeira nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor da segunda nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor da terceira nota: ");
            n3 = Convert.ToDouble(Console.ReadLine());
            medp = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;
            Console.Write("A média ponderada das notas digitadas é: " + medp);
        }//FIM
    }
}
