using System;

class MainClass
{
    public static void Main(string[] args)
    {
        Random aleatorio = new Random();
        int dado = 0, total = 0, i = 0;
        string continuar = "s", ok = "n";

        while (continuar == "s" && ok == "n")
        {
            i += 1;
            dado = aleatorio.Next(1, 13);
            Console.WriteLine("Dado = " + dado);
            while (dado == 12)
            {
                total += dado;
                Console.WriteLine("Total = " + total);
                if (total >= 100)
                {
                    ok = "s";
                    Console.WriteLine("Ganaste UwU");
                    Console.WriteLine("Total = " + total + "puntos");
                }
                else
                {
                    Console.WriteLine("¿Quiere Continuar? (s/n)");
                    continuar = Console.ReadLine();
                }
                if (continuar == "s")
                {
                    i += 1;
                    dado = aleatorio.Next(1, 13);
                    Console.WriteLine("Dado = " + dado);
                    if (dado == 10)
                    {
                        ok = "s";
                        Console.WriteLine("Ganaste alv");
                        dado = 0;
                    }
                }
            }
            if (i <= 3)
            {
                total += dado;
                Console.WriteLine("Total = " + total);
                Console.WriteLine("¿Quiere Continuar? (s/n)");
                continuar = Console.ReadLine();
            }
            else if (i > 3)
            {
                if (dado == 2 || dado == 4 || dado == 6 || dado == 8 || dado == 10)
                {
                    total += dado;
                    Console.WriteLine("Total = " + total);
                    if (total >= 100)
                    {
                        ok = "s";
                        Console.WriteLine("Ganaste UwU");
                        Console.WriteLine("Total = " + total + "puntos");
                    }
                    else
                    {
                        Console.WriteLine("¿Quiere Continuar? (s/n)");
                        continuar = Console.ReadLine();
                    }
                }
                else
                {
                    total = 0;
                    Console.WriteLine("La suerte no siempre esta de tu lado");
                    Console.WriteLine("Total = " + total + " puntos");
                    continuar = "n";
                }
            }
        }
        Console.WriteLine("Gracias por jugar ♥");
    }
}
