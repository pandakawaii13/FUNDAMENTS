using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GG
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Ingrese el número (n) de datos que hay");
            int n = int.Parse(Console.ReadLine());
            int[] edades = new int[ n ];
            string[] nombres = new string[ n ];
            int max = 0, min = 1, total = 0, indice= 0;
            double sumatoria = 0;
            for (int i = 0; i < edades.Length; i++)
            {
               
                Console.WriteLine("Ingrese el nombre");
                nombres[i] = (Console.ReadLine());
                Console.WriteLine("Ingrese la edad");
                edades [i] = int.Parse(Console.ReadLine());
                
                if (edades [i] > max)
                {
                    max = edades[i];
                    indice = i;
                }
                if (edades [i] < min)
                {
                    min = edades[i];
                    indice = i;
                }
            }
            for (int i = 0; i < edades.Length; i++)
            {
                total += edades[i];
                Console.WriteLine("Total " + total);
            }
            double promedio = total / n;
            double cerca = 0;
            string nombrec = "i";

            for (int i = 0; i < edades.Length; i++)
            {
                
                 double diferencia = promedio - edades[i];
                 
                 if (Math.Abs(diferencia) < cerca)
                {
                    cerca = diferencia;
                    nombrec = nombres[i];
                }
            }
            for (int i = 0; i < edades.Length; i++)
            {
                sumatoria += Math.Pow(promedio - edades[i], 2);
            }
            double d = Math.Sqrt(sumatoria / n);
        
            Console.WriteLine("Edad mayor es" + max + "Su nombres es " + nombres[indice]);
            Console.WriteLine("Edad menor es" + min + "Su nombres es " + nombres[indice]);
            Console.WriteLine("El promedio es de" + promedio + "es " + nombrec);
            Console.WriteLine("Desviación" + d);

        }
    }
}
