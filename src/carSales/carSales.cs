using System;
public class carSales {
	public static void Main() {
		string employeeName;
		double salesNumber;

		Console.WriteLine("Please enter a employee name");
		employeeName = Console.ReadLine();

		Console.WriteLine("Please enter the sales of employee " + employeeName);
		salesNumber = Convert.ToDouble(Console.ReadLine());

		if (salesNumber >= 200000) {
			Console.WriteLine("Employee is eligble for the bonus");
			Console.WriteLine("The bonus will be " +salesNumber*0.0235 +"$");
	}
		else {
			Console.WriteLine("Employee is not eligble for the bonus");
		}
	}
}

