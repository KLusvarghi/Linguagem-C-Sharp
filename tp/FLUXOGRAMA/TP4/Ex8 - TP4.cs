using System;

namespace Ex3___AULA_3
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            double n1, n2, n3, medp;
            Console.Write("Digite o valor da primeira nota: ");
            n1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor da segunda nota: ");
            n2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor da terceira nota: ");
            n3 = Convert.ToDouble(Console.ReadLine());
            medp = ((n1 * 2) + (n2 * 3) + (n3 * 5)) / 10;
            Console.Write("A média ponderada das notas digitadas é: " + medp);
        }//Fim
    }
}
