using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DESAFIO_3_1
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Por favor ingrese el número de SMMLV que gana");
            double No = double.Parse(Console.ReadLine());
            double SMMLV = No * 828116;

            if (SMMLV < 1656232)
            {
                Console.WriteLine("Debe cancelar la tarifa A");
                Console.WriteLine("Y debe cancelar $3200");
            }
            //5 SALARIOS SON 4140579
            else if (1656232 <= SMMLV && SMMLV <= 4140579)
            {
                Console.WriteLine("Debe cancelar la tarifa B");
                Console.WriteLine("Y debe cancelar $12700");
            }
            else
            {
                Console.WriteLine("Debe cancelar la tarifa C");
                Console.WriteLine("Y debe cancelar $33500");
            }

        }
    }
}