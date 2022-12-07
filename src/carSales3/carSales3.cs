using System;
public class carSales3 {
	public static void Main() {
		
		string isEV;
		double netValue;
		
		Console.WriteLine("Is the vehicle an EV?");
		isEV = Console.ReadLine();
		isEV = isEV.ToLower();

		Console.WriteLine("Please enter the net value of the car");
		netValue = Convert.ToDouble(Console.ReadLine());
		
		switch(isEV) {
			case "yes": case "ja":
				Console.WriteLine("Vehicle is an EV");
				Console.WriteLine("EV price reduction is : " +netValue*0.2);
				if (netValue >= 50000) {
					Console.WriteLine("The vehicle is eligle for another price reduction of 5000$");
					Console.WriteLine("The final price of the vehicle is : "+((netValue*0.8)-5000));
				}
				else {
					Console.WriteLine("The vehicle is not eligble for another price reduction");
					Console.WriteLine("The final price of the vehicle is : "+(netValue*0.8));
				}
				break;
			case "no": case "nein":
				Console.WriteLine("Vehicle has an piston engine");
				Console.WriteLine("The regular price reduction is : "+(netValue*0.1));
				Console.WriteLine("The final price of the vehicle is : "+(netValue*0.9));
				break;
			default :
				Console.WriteLine("You didn't properly specify whether the vehicle is an EV or not. Please try again!");
				Main();
				break;
		}
	}
}
			
		







