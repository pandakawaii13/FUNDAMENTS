using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFÍO_2_2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Ingrese el hipotenusa t, el ángulo a ");
            double t = double.Parse(Console.ReadLine());
            double aGrados = double.Parse(Console.ReadLine());

            // CONVERSIÓN DE ÁNGULOS A RADIANES
            double a = aGrados * (Math.PI / 180.0);

            // CALCULAR Y y Z
            double y = Math.Sin(a) * t;
            double z = Math.Sqrt((t) * (t) - (y) * (y));
            double c = Math.Atan(z / y) * (180.0 / Math.PI);

            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(c);


        }
    }
}
