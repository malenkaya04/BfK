using System;
public class imageCalc{
    public static void Main(String[] args) {
        //Prompting user for color depth information; declaring and initializing variables with console input
        Console.WriteLine("Please ente a name for the color depth!");
        var colorDepthName = Console.ReadLine();
        Console.WriteLine("Please enter a color depth!");
        var colorDepth = Console.ReadLine();
        //Creating some more variables to waste more RAM. required by task specifications
       float imageSizeBit = imageSizeCalc(Convert.ToInt16(colorDepth));
       float imageSizeByte = imageSizeBit/8;
       float imageSizeKB = imageSizeByte/1024;
       //output resulst to terminal
       Console.WriteLine("Dateigröße in der Farbtiefe "+ Convert.ToString(colorDepthName)+"\n");
       Console.WriteLine("Dateigröße in Bit : "+Convert.ToString(imageSizeBit));
       Console.WriteLine("Dateigröße in Byte : "+Convert.ToString(imageSizeByte));
       Console.WriteLine("Dateigröße in Kilobyte : "+Convert.ToString(imageSizeKB));
    }
    
    public static int imageSizeCalc(int colorDepth ) {
        return (1024*768*colorDepth)+54; 
    }
}