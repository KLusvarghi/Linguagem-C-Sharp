/*
DESAFIO (Crie um gerador de e-mail que solicite o nome do usuário completo e mostre ao final o email:
nome.ultimosobrenome @fatec.sp.gov.br
*/
using System;

namespace Ex5___AULA_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, primeiroN, ultimoN, email;
            Console.Write("Digite seu nome completo: ");
            nome = Console.ReadLine();
            primeiroN = nome.Substring(0, (nome.IndexOf(" ")));
            ultimoN = nome.Substring(nome.LastIndexOf(" "));
            ultimoN = ultimoN.TrimStart();
            email = ultimoN + "@fatec.sp.gov.br";
            Console.Write("O email ficará: "+ primeiroN+ "."+email);
            Console.ReadKey();
        }
    }
}
