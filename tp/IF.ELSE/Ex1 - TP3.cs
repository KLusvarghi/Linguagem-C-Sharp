using System;

namespace Ex1___AULA_3
{
    class Program
    {
        static void Main(string[] args)
        {//Início
            Console.Write("Digite o Raio do Circulo: ");
            double raio = Convert.ToDouble(Console.ReadLine());
            double area = Math.PI * Math.Pow(raio, 2);
            double diametro = 2 * raio;
            double perimetro = 2 * Math.PI * raio;
            Console.WriteLine("A diâmetro do triangulo é: " + diametro);
            Console.WriteLine("A área do triangulo é: " + area);
            Console.WriteLine("A perímetro do triangulo é: " + perimetro);
            Console.ReadKey();
        }//Fim
    }
}