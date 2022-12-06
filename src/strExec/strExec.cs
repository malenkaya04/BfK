using System;
public class strExec {
	public static void Main(String[] args) {
		double preis = 5.5;
		int menge;
		double gesamtpreis;

		Console.WriteLine("****Gesamtpreisermittlung****");
		Console.WriteLine("Geben sie die Bestellmenge ein");

		menge = Convert.ToInt32(Console.ReadLine());

		gesamtpreis = menge * preis;

		Console.WriteLine("Gesamtpreis: " + gesamtpreis);
	}
}
