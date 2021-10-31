using System;

namespace Ex3___AULA_3
{
    class Program
    {
        static void Main(string[] args)
        {//Início
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
        }//Fim
    }
}
