using System;

class MainClass {
  public static void Main (){ 
    Random aleatorio = new Random();
		string continuar = "s";
		int carta1 = aleatorio.Next(1,11);
		Console.WriteLine("Carta 1 = " + carta1);
		int carta2 = aleatorio.Next(1,11);
		Console.WriteLine("Carta 2 = " + carta2);
		int total = carta1 + carta2;
		Console.WriteLine("Total = " + total);
		
		Console.WriteLine("Desea continuar (s/n): ");
		continuar = Console.ReadLine();
		
	while (continuar == "s" && total < 21) {
		int cartasiguiente = aleatorio.Next(1,11);
		Console.WriteLine("Carta siguiente = " + cartasiguiente);
		total += cartasiguiente;
		Console.WriteLine("Total = " + total);
		if (total == 21){
			Console.WriteLine("Total = " + total);
			Console.WriteLine("YEY ganaste");
	   }
		else if (total > 21){
			Console.WriteLine("Total = " + total);
			Console.WriteLine("Perdiste, bye");
		}
		else {
			Console.WriteLine("Total = " + total);
			Console.WriteLine("Desea continuar (s/n): ");
			continuar = Console.ReadLine();
		}
		 
	}
  Console.WriteLine("Su total es " + total);
	    Console.WriteLine("Gracias por jugar");
  }
}

    
