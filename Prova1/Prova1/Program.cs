using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova1
{
    class Program
    {
        static void mold()
        {
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            int l = 3;
            Console.SetCursorPosition(6, l);

            Console.WriteLine("╔═════════════════════════════════════════════════════╗");
            for (l = 4; l <= 20; l++)
            {
                Console.SetCursorPosition(6, l);
                Console.WriteLine("║                                                     ║");
            }
            Console.SetCursorPosition(6, l);

            Console.WriteLine("╚═════════════════════════════════════════════════════╝");
        }
        static double resistencia(double f, double d){ //Reatância Capacitiva
            double xc = 1 / (2 * Math.PI * f * d);
            xc = Math.Round(xc, 7);
            return xc;
        }
        static bool bissexto(int ano){ //Verificar ano bissexto
            bool retorno = false;
            if (ano % 4 == 0)
            {
                retorno = true;
            }
            return retorno;
        }
        static double Impedancia(double r, double xl, double xc){ //Impedância
            double z = Math.Pow(r, 2) + (Math.Pow(xl - xc, 2));
            z = Math.Sqrt(z);
            z = Math.Round(z, 5);
            return z;
        }
        static void Main(string[] args)
        {//INICIO
            Console.Title = "AVALIAÇÃO DE PROGRAMAÇÃO EM MICROINFORMÁTICA";
            string respo = "s";
            do
            { 
            mold();
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(6, 3);
                    Console.WriteLine("╔═════════════════════════════════════════════════════╗");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(6, 4);
                    Console.WriteLine("║                Escolha uma das opções               ║");
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(6, 5);
                    Console.WriteLine("╠═════════════════════════════════════════════════════╣");
                inicio:
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.SetCursorPosition(13, 7);
                    Console.WriteLine("(1) Reatância Capacitiva");
                    Console.SetCursorPosition(13, 8);
                    Console.WriteLine("(2) Ano bissexto");
                    Console.SetCursorPosition(13, 9);
                    Console.WriteLine("(3) Impedância");

                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.SetCursorPosition(45, 8);
                    Console.WriteLine("═══════════════╣");
                    Console.SetCursorPosition(44, 7);
                    Console.WriteLine("╔═╗");
                    Console.SetCursorPosition(44, 8);
                    Console.WriteLine("║ ║");
                    Console.SetCursorPosition(44, 9);
                    Console.WriteLine("╚═╝");
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.SetCursorPosition(45, 8);
                    int op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.SetCursorPosition(8, 12);
                            Console.Write("Digite a frequência da corrente em hertz(Hz): ");
                            double a = Convert.ToInt32(Console.ReadLine());
                            Console.SetCursorPosition(8, 13);
                            Console.Write("Digite a capacidade do capacitor em Farad(F): ");
                            double b = Convert.ToInt32(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.SetCursorPosition(15, 15);
                            Console.WriteLine("A Reatância Capacitiva é: " + resistencia(a, b));
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.SetCursorPosition(13, 12);
                            Console.Write("Digite um ano: ");
                            int anob = Convert.ToInt32(Console.ReadLine());
                            bool resp = bissexto(anob);
                            if (resp == true)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.SetCursorPosition(19, 14);
                                Console.Write("O ano digitado é Bissexto");
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.SetCursorPosition(18, 14);
                                Console.Write("O ano digitado não é Bissexto");
                            }
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.SetCursorPosition(9, 12);
                            Console.Write("Digite o valor da Resistividade: ");
                            double re = Convert.ToInt32(Console.ReadLine());
                            Console.SetCursorPosition(9, 13);
                            Console.Write("Digite o valor da reatância indutiva(XL): ");
                            double reI = Convert.ToInt32(Console.ReadLine());
                            Console.SetCursorPosition(9, 14);
                            Console.Write("Digite o valor da reatância capacitiva(XC):");
                            double reC = Convert.ToInt32(Console.ReadLine());
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.SetCursorPosition(15, 16);
                            Console.WriteLine("O valor da Impedância é: " + Impedancia(re, reI, reC));
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.SetCursorPosition(23, 10);
                            Console.WriteLine("«« Valor incorreto »»");
                            goto inicio;
                            break;
                    }
                }
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(42, 18);
                Console.WriteLine("╔═╗");
                Console.SetCursorPosition(42, 19);
                Console.WriteLine("║ ║");
                Console.SetCursorPosition(42, 20);
                Console.WriteLine("╚═╝");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(17, 19);
                Console.Write("Deseja continuar? [s/n]: ");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.SetCursorPosition(43, 19);
                respo = Console.ReadLine();
                respo = respo.ToUpper();
            } while (respo == "s");

            Console.ReadKey();
        }//FIM
    }
}
