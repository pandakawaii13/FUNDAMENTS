using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLACKJACKMODIFICADO
{
    class MainClass
    {
        public static void Main()
        {
            Random aleatorio = new Random();
            int total = 0;
            int carta1 = 0;
            int carta2 = 0;
            int jugadores = 0;
            int indice = 0;
            int max = 0;

            Console.Write("Ingresar la cantidad de judadores (n) ");
            int n = int.Parse(Console.ReadLine());

            int[] jugador = new int[n];
            int[] puntaje = new int[n];

            for (int i = 0; i < n; i += 1)
            {
                jugadores += 1;
                jugador[i] = jugadores;
                Console.WriteLine("Jugador " + jugador[i]);

                carta1 = aleatorio.Next(1, 11);
                Console.WriteLine(" Carta 1 = " + carta1);
                carta2 = aleatorio.Next(1, 11);
                Console.WriteLine(" Carta 2 = " + carta2);
                total = carta1 + carta2;
                Console.WriteLine(" Total = " + total);

                Console.WriteLine("Desea continuar (s/n): ");
                string continuar = Console.ReadLine();


                while (continuar == "s" && total < 21)
                {
                    carta1 = aleatorio.Next(1, 11);
                    total += carta1;
                    puntaje[i] = total;

                    Console.WriteLine("carta: " + carta1);
                    Console.WriteLine("Puntos: " + total);
                     if (total < 21)
                    {
                        Console.WriteLine("Total = " + total);
                        Console.WriteLine("Desea continuar (s/n): ");
                        continuar = Console.ReadLine();
                    }
                    if (total == 21)
                    {
                        Console.WriteLine("Total = " + total);
                        Console.WriteLine("YEY ganaste");
                    }
                    else if (total > 21)
                    {
                        Console.WriteLine("Total = " + total);
                        Console.WriteLine("Perdiste, bye");
                        puntaje[i] = 0;
                    }
                }
                if (puntaje[i] > max)
                {
                    max = puntaje[i];
                    indice = i;
                }
            }
            Console.WriteLine("Su total es " + total);
             if(indice == -1) Console.WriteLine("No hay ganador");
            else Console.WriteLine("El ganador es " + jugador[indice] + " el número es  " + max);
             Console.WriteLine("Gracias por jugar");
        }
    }
}
