using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_4_1
{
     public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Ingrese número de votos del partido a, número de votos del partido b, número de votos en blanco, número de votos anulados, número total de la población de todas las edades, porcentaje (de 0 a 100%) de la población que es mayor de edad");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int blancos = int.Parse(Console.ReadLine());
            int anulados = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());

            int totales = (a + b + blancos + anulados);

            bool A = (totales) > n;
            bool B = Math.Abs((a - b)) < (totales * 0.1);
            bool C = (n * (p / 100)) < (n * 0.3);
            bool D = a < b;

            if ((A || B) && C) Console.WriteLine("Las elecciones deben ser ejecutadas nuevamente");
            else if (D) Console.WriteLine("El ganador es el partido 2");
            else Console.WriteLine("El ganador es el partido 1");

        }
    }
}
