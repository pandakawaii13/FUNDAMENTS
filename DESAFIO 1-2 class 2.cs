using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESADIO_1_2_class_2
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("ingrese d,b,y");
            // INGRESAR DATOS
            double dGrados = double.Parse(Console.ReadLine());
            double bGrados = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            // CONVERSIÓN GRADOS - RADIANES
            double d = dGrados * (Math.PI / 180.0);
            double b = bGrados * (Math.PI / 180.0);
            // HALLAR ÁNGULO A
            double a = 180 - b;
            //HALLAR Z
            double z = (y / Math.Tan(a));

            Console.WriteLine("z =" + z);


        }
    }

}
