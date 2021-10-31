using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {//inicio
            string nome, nome_ma,nome_mi,nome_corte,nome_sub,nome_esp;
            int pos;
            Console.Write("Digite seu nome: ");
            nome = Console.ReadLine();
            nome_ma = nome.ToUpper();
            nome_mi = nome.ToLower();
            pos = nome_mi.IndexOf("c");
            nome_corte = nome.Substring(2, 5);
            nome_sub = nome_mi.Replace("a","o");
            nome_esp = nome_ma.Trim();
            Console.WriteLine("Seu nome em maiúsculo: " + nome_ma);
            Console.WriteLine("Seu nome em minúsculo: " + nome_mi);
            Console.WriteLine("A posição do c é: " + pos);
            Console.WriteLine("Parte do nome: " + nome_corte);
            Console.WriteLine("Trocar o a pelo o: " + nome_sub);
            Console.WriteLine("Tirando o espaço: "+nome_esp);
            Console.ReadKey();
        }//fim
    }
}
