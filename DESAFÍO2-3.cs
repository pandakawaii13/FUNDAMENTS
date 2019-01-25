using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFÍO_2_3
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Ingrese el ángulo c, el cateto z ");
            double cGrados = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());

            // CONVERSIÓN A RADIANES
            double c = cGrados * (Math.PI / 180.0);
            //CALCULAR T, Y, A
            double t = z / Math.Sin(c);
            double y = Math.Sqrt((t) * (t) - (z) * (z));
            //CONVERSIÓN DE NUEVO A GRADOS
            double a = 180 - 90 - c * (180.0 / Math.PI);

            Console.WriteLine(t);
            Console.WriteLine(y);
            Console.WriteLine(a);

        }
    }

}
