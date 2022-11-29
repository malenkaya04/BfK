using System;
public class imageCalc{
    public static void Main(String[] args) {
       String[] colorDepth = new String[2];
        Console.WriteLine("Please ente a name for the color depth!");
        colorDepth[0] = Console.ReadLine();
        Console.WriteLine("Please enter a color depth!");
        colorDepth[1] = Console.ReadLine();
       float imageSize = imageSizeCalc(Convert.ToInt16(colorDepth[1]));
       Console.WriteLine("Dateigröße in der Farbtiefe "+ colorDepth[0]+"\n");
       Console.WriteLine("Dateigröße in Bit : "+Convert.ToString(imageSize));
       Console.WriteLine("Dateigröße in Byte : "+Convert.ToString(imageSize/8));
       Console.WriteLine("Dateigröße in Kilobyte : "+Convert.ToString(imageSize/8/1204));
    }
    
    public static int imageSizeCalc(int colorDepth ) {
        return (1024*768*colorDepth)+54; 
    }
}