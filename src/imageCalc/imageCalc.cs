using System;
public class imageCalc{
    public static void Main(String[] args) {
        //Prompting user for color depth information; declaring and initializing variables with console input
        Console.WriteLine("Please enter a name for the color depth!");
        var colorDepthName = Console.ReadLine();
        Console.WriteLine("Please enter a color depth!");
        var colorDepth = Console.ReadLine();
        //Creating some more variables to waste more RAM. required by task specifications
       float imageSizeBit = imageSizeCalc(Convert.ToInt32(colorDepth));
       float imageSizeByte = imageSizeBit/8;
       double imageSizeKB = Math.Round((imageSizeByte/1024), 3);
       //output results to terminal
       Console.WriteLine("File in color depth"+ Convert.ToString(colorDepthName)+"\n");
       Console.WriteLine("File size in Bit : "+Convert.ToString(imageSizeBit));
       Console.WriteLine("File size in Byte : "+Convert.ToString(imageSizeByte));
       Console.WriteLine("File size in Kilobyte : "+Convert.ToString(imageSizeKB));
    }
    
    public static int imageSizeCalc(int colorDepth ) {
        return (1024*768*colorDepth)+54;
    }
}
