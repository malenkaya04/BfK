using System;
public class salesCalc {
	public static void Main() {
		
		//Prevent compile error
		double netValue = 0;

		Console.WriteLine("Please enter the net value of the order");

		try {
			netValue = Convert.ToDouble(Console.ReadLine());
		

		if (netValue > 2000) {
			Console.WriteLine("----Sale Calculator----\n");
			Console.WriteLine("Sale applied : 5%");
			Console.WriteLine("Net value : " + netValue);
			Console.WriteLine("Sale value : " + netValue * 0.05);
			Console.WriteLine("New total : " + netValue * 0.95);
		}
		else if (netValue > 1000) {
			Console.WriteLine("----Sale Calculator----\n");
			Console.WriteLine("Sale applied : 3%");
			Console.WriteLine("Net value : " + netValue);
			Console.WriteLine("Sale value : " + netValue * 0.03);
			Console.WriteLine("Net total : " + netValue * 0.97);
		}
		else {
			Console.WriteLine("----Sale Calculator----\n");
			Console.WriteLine("No sale applicable");
			Console.WriteLine("Total : " + netValue);
		}
		
	 } catch (Exception) {
		 Console.WriteLine("Please enter a valid number and try again");
		 Main();

	}
 }
}
