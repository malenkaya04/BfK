using System;
public class converterToF {
    public static void Main () {
        try {
        //Asking for customer data
        //Declaring the variables and initializing them with converted user input
        Console.WriteLine("Welcome to OilDelivery LLC!");
        Console.WriteLine("Please enter a name!");
        var customerName = Console.ReadLine();
        Console.WriteLine("What is the current oil price?");
        var oilPrice = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("What was the load of the delivery vehicle before delivery?");
        var amountBefore = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("What was the load of the delivery vehicle after delivery?");
        var amountAfter = Convert.ToDouble(Console.ReadLine());
        //Validating customer data
        //If any data is not correctly formated, notify user and restart program
        if (amountAfter > amountBefore || customerName == "" || oilPrice < 0) {
            Console.WriteLine("Please check your inputs and try again!");
            Main(); 
            }
        else {
            formatedOutput(customerName, amountBefore-amountAfter, oilPrice);
        }
        }
        //Catching exceptions by leaving double string empty / not entering valid inputs
        catch (Exception) {
            Console.WriteLine("Please check your inputs and try again!");
            Main();
        }
    }
    //helper method for formated output
    public static void formatedOutput(String customerName, double amountDelivered, double oilPrice) {
        //Final values get calculated from params and constant for sales tax
        Console.WriteLine("---- Oil Delivery LLC ----");
        Console.WriteLine("Customer name : "+customerName);
        Console.WriteLine("Delivered Amount : " +amountDelivered+" Liter");
        Console.WriteLine("Net value :" +Convert.ToString(amountDelivered*oilPrice)+ " €");
        Console.WriteLine("Sales tax :"+Convert.ToString(amountDelivered*oilPrice*0.19)+ " €");
        Console.WriteLine("Gross value including sales tax : "+Convert.ToString(amountDelivered*oilPrice*1.19)+ " €");
    }
}
