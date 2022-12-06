using System;
public class carSales2 {
	public static void Main() {
		double netValue;
		
		Console.WriteLine("Please enter the net value of the car");
		netValue = Convert.ToDouble(Console.ReadLine());

		Console.WriteLine("Net value was : "+netValue);
		Console.WriteLine("Price was reduced by :"+netValue*0.1);

		if (netValue >= 50000) {
			Console.WriteLine("Car is eligble for a price reduction by 5000$");
			Console.WriteLine("Final price is : "+((netValue*0.9)-5000));
		}
		else {
			Console.WriteLine("Car is not eligble for further price reduction");
			Console.WriteLine("Final price is : "+netValue*0.9);

		}
	}
}
