using System;
public class converterToF {
    public static void Main () {
        try {
        //Asking for customer data
        Console.WriteLine("Willkommen bei OilDelivery GmbH!");
        Console.WriteLine("Bitte geben sie ihren Namen ein!");
        var customerName = Console.ReadLine();
        Console.WriteLine("Was ist der aktuelle Heizölpreis?");
        var oilPrice = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Wie war der Tankstand des Lieferfahrzeugs vor der Lieferung?");
        var amountBefore = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Wie war der Tankstand des Lieferfahrzeugs nach der Lieferung?");
        var amountAfter = Convert.ToDouble(Console.ReadLine());
        //Validating customer data
        if (amountAfter > amountBefore || customerName == "" || oilPrice < 0) {
            Console.WriteLine("Bitte überprüfen sie ihre Angaben und versuchen sie es erneut!");
            Main(); 
            }
        else {
            formatedOutput(customerName, amountBefore-amountAfter, oilPrice);
        }
        }
        //Catching exceptions by leaving double string empty / not entering valid inputs
        catch (Exception) {
            Console.WriteLine("Bitte überprüfen sie ihre Angaben und versuchen sie es erneut!");
            Main();
        }
    }

    public static void formatedOutput(String customerName, double amountDelivered, double oilPrice) {
        Console.WriteLine("---- Heizölrechnung ----");
        Console.WriteLine("Kundenname : "+customerName);
        Console.WriteLine("Gelieferte Menge : " +amountDelivered+" Liter");
        Console.WriteLine("Nettowert :" +Convert.ToString(amountDelivered*oilPrice)+ " €");
        Console.WriteLine("Mehrwertsteur :"+Convert.ToString(amountDelivered*oilPrice*0.19)+ " €");
        Console.WriteLine("Rechnungsbetrag inkl. Mehrwersteuer : "+Convert.ToString(amountDelivered*oilPrice*1.19)+ " €");
    }
}