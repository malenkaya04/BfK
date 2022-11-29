using System;
public class converterToF {
    public static void Main () {
        Console.WriteLine("Hello! Please enter a temperature!");
        var tempInC = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Your temeperature is : " +Convert.ToString(convert(tempInC)));
    }

    public static double convert(double tempInC) {
        return ((tempInC * 1.8) +32);
    }

    public static void formatedOutput() {
        Console.WriteLine("---- Heizölrechnung ----");
    }
}