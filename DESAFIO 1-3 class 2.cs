using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_1_3_class_2
{
     public class Program
    {
        public static void Main()
        {
            Console.WriteLine("ingrese w,d,x");
            // INGRESAR DATOS
            double w = double.Parse(Console.ReadLine());
            double dGrados = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());

            // CONVERSIÓN GRADOS - RADIANES
            double d = dGrados * (Math.PI / 180.0);
            // HALLAR Z
            double z = Math.Sin(d) * w;
            //HALLAR Y
            double y = (z / Math.Tan(d)) - x;


            Console.WriteLine("y =" + y);


        }
    }
}