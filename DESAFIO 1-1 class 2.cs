using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_1_1_class_2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("ingrese b,z,y");
            // INGRESAR DATOS
            double bGrados = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            // CONVERSIÓN GRADOS - RADIANES
            double b = bGrados * (Math.PI / 180.0);
            // HALLAR ÁNGULO A
            double a = Math.Atan(y / z);
            //HALLAR X
            double x = (Math.Tan(a + b) * z) - y;

            Console.WriteLine("x =" + x);


        }
    }

}