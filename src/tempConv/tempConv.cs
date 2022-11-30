using System;
public class converterToF {
    public static void Main () {
        //Prompting input from user
        Console.WriteLine("Hello! Please enter a temperature!");
        //Declare variable and initialize with read-in value from terminal. Gets converted to double
        var tempInC = Convert.ToDouble(Console.ReadLine());
        //Creating output, calls seperate function to calculate the final value which gets appended to output
        Console.WriteLine("Your temeperature is : " +Convert.ToString(convert(tempInC)));
    }
    //Seperate function to do the conversion
    public static double convert(double tempInC) {
        return ((tempInC * 1.8) +32);
    }
}