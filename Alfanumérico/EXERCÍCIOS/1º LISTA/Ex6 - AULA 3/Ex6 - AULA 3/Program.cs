﻿//Escreva um programa para ler as dimensões de um retângulo (base e altura), calcular e escrever a área do retângulo.

using System;

namespace Ex2___AULA_3
{
    class Program
    {
        static void Main(string[] args)
        {//INICIO
            double bas, altu, area;
            Console.Write("Digite o comprimento  da base do triâgulo: ");
            bas = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o comprimento  da altura do triâgulo: ");
            altu = Convert.ToDouble(Console.ReadLine());
            area = bas*altu;
            Console.Write("A área do triâgulo é de: " + area);
        }//FIM
    }
}
