using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONTRATOS
{
   public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Ingrese su salario mensual");
            Console.WriteLine("Ingrese su tipo de contrato, 1 dependiente, 2 independiente");
            double Salario = double.Parse(Console.ReadLine());
            double NoContrato = double.Parse(Console.ReadLine());
            double Base = (Salario * 0.4);
            double Prima = Salario;
            double ARL = 0;

            if (Base < 828116)
            {
                Base = 828116;
            }

            if (NoContrato == 2)
            {

                Console.WriteLine("Ingrese de 1 a 5 el nivel de riesgo");
                double NR = double.Parse(Console.ReadLine());
                if (NR == 1)
                {
                    ARL = (Base * 0.00522);
                }
                else if (NR == 2)
                {
                    ARL = (Base * 0.01044);
                }
                else if (NR == 3)
                {
                    ARL = (Base * 0.02436);
                }
                else if (NR == 4)
                {
                    ARL = (Base * 0.04350);
                }
                else
                {
                    ARL = (Base * 0.06960);
                }
                double Pensión = (Base * 0.16);
                double EPS = (Base * 0.125);
                double SMR = (Salario - EPS - Pensión - ARL);
                double SA = (Salario) * 12;

                Console.WriteLine("SMR" + SMR);
                Console.WriteLine("SA" + SA);

            }

            if (NoContrato == 1)
            {
                double Pensión = (Base * 0.04);
                double EPS = (Base * 0.04);
                double SMR = (Salario - Pensión - EPS);
                double SA = (Salario) * 12 + Prima;

                Console.WriteLine("SMR" + SMR);
                Console.WriteLine("SA" + SA);
            }

        }
    }
}
