using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleatorio = new Random();
            int dado1 = 0, total = 0, i = 0, vida = 3, dado2 = 0, dobles = 0;
            string continuar = "s";

            while (continuar == "s")
            {
                i++;
                dado1 = aleatorio.Next(1, 7);
                total += dado1;
                Console.WriteLine("Dado: " + dado1);
                Console.WriteLine("TOTAL : " + total + " puntos");

                if (i % 2 == 0)
                {
                    vida -= 1;
                    Console.WriteLine("Perdiste 1 vida ↓ = total : " + vida + " vidas");
                }

                if (i % 3 == 0)
                {
                    dado2 = aleatorio.Next(1, 7);
                    Console.WriteLine("Dado2: " + dado2);
                    total += (dado1 + dado2);
                    Console.WriteLine("TOTAL : " + total + " puntos");

                    if (dado1 == dado2)
                    {
                        dobles++;
                        Console.WriteLine("Tuviste un doble YEY " );
                        vida++;
                        Console.WriteLine("Ganaste 1 vida ♥ = total : " + vida + " vidas");
                    }
                    else
                    {
                        dobles = 0;
                    }
                }
                if (vida == 0)
                {
                    Console.Write("Perdiste ¬-¬ ");
                    break;
                }
                Console.WriteLine("Desea continuar (s/n) : ");
                if (Console.ReadLine() != "s") break;
            }
            Console.WriteLine("FIN ");
        }
     }
}
