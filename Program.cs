using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFÍO_2_1_2_3
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Ingrese el cateto z, y ");
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            // HALLAR HIPOTENUSA
            double t = Math.Sqrt((z) * (z) + (y) * (y));

            // HALLAR ÁNGULO a
            double a = (Math.Asin(y / t) * (180.0 / Math.PI));

            // HALLAR ÁNGULO c
            double c = 180 - 90 - a;

            // SALIDA DEL RESULTADO	
            Console.WriteLine(t);
            Console.WriteLine(a);
            Console.WriteLine(c);


        }
    }
} 