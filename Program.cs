using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {

            string continuar = "s";
            Random aleatorio = new Random();
            int dado1 = aleatorio.Next(1, 7);
            Console.WriteLine("Dado 1 = " + dado1);
            int dado2 = aleatorio.Next(1, 7);
            Console.WriteLine("Dado 2 = " + dado2);
            int total = dado1 + dado2;
            Console.WriteLine("Total = " + total);
            int i = 0;
            int doble = 0;
            int mayores = 0;
            bool a = mayores > 6;
            bool b = (doble != 3 || doble != 5 || doble != 7 || doble != 9 || doble != 11);


            Console.WriteLine("Desea continuar (s/n): ");
            continuar = Console.ReadLine();

            while (continuar == "s" && dado1 != 1 || dado2 != 1)
            
                {
                Console.WriteLine("dado1 = " + dado1);
                Console.WriteLine("dado2 = " + dado2);
                    if (dado1 == 1 && dado2 == 1) {
                    total = 0;
                    Console.WriteLine("(Perdiste)");
                }
               else if (total == 100 || total > 100 )
                    {
                        Console.WriteLine("Total = " + total);
                        Console.WriteLine("YEY ganaste");
                    if (total == 4 || total == 6 || total == 8 || total == 10 || total == 12 );
                    {

                        doble ++;
                        Console.WriteLine("Total = " + total);
                        Console.WriteLine("YEY ganaste");
                    }
                    }
                    else
                {
                    Console.WriteLine("Desea continuar (s/n): ");
                    continuar = Console.ReadLine();
                    mayores ++;
                    i++;

                }

            }
            double porcentaje = (mayores * 100 / i);
            Console.WriteLine("Su total fue " + total + "puntos");
            Console.WriteLine("Gracias!");
        }
    }
}
