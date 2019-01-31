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
            }
            //4 SALARIOS SON 3312464
            else if (1656232 <= SMMLV && SMMLV <= 3312463)
            {
                Console.WriteLine("Debe cancelar la tarifa B");
            }
            else
            {
                Console.WriteLine("Debe cancelar la tarifa C");
            }

        }
    }
}