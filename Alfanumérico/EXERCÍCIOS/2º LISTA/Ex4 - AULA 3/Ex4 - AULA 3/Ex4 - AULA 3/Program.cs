//Crie um gerador de e-mail que solicite o nome do usuário completo e mostre ao final o email: nome @fatec.sp.gov.br
using System;

namespace Ex4___AULA_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, primeiroN, email;
            Console.Write("Digite seu nome completo: ");
            nome = Console.ReadLine();
            primeiroN = nome.Substring(0, (nome.IndexOf(" ")));
            email = primeiroN + "@fatec.sp.gov.br";
            Console.Write("O seu email ficará: " +email);
            Console.ReadKey();
        }
    }
}
