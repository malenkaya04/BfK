using System;
public class salesCalc {
	public static void Main() {
		
		//Prevent compile error
		double netValue = 0;

		Console.WriteLine("Please enter the net value of the order");

		try {
			netValue = Convert.ToDouble(Console.ReadLine());
		}
		catch (Exception) {
			Console.WriteLine("Please enter a valid value and try again");
		}

		Console.WriteLine("----Sale Calculator----\n");
		Console.WriteLine("Net value : " + netValue);
		Console.WriteLine("Sale value : " + netValue * 0.03);
		Console.WriteLine("New total : " + netValue * 0.97);
	}
}
