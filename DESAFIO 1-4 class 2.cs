using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_1_4_class_2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("ingrese w,t,c");
            // INGRESAR DATOS
            double w = double.Parse(Console.ReadLine());
            double t = double.Parse(Console.ReadLine());
            double cGrados = double.Parse(Console.ReadLine());

            // CONVERSIÓN GRADOS - RADIANES
            double c = cGrados * (Math.PI / 180.0);
            // HALLAR Z
            double z = Math.Sin(c) * t;
            // HALLAR Y
            double y = Math.Sqrt((t * t) - (z * z));
            double xy = (w * w) - (z * z);
            double x = Math.Sqrt(xy) - y;

            Console.WriteLine("x =" + x);


        }
    }

}


