using System;
public class mainClass {
	public static void Main () {
		Console.WriteLine("Loaded Main class!");
		pointer();
	}

	public static unsafe void pointer () {
		int a = 5;
		int* b = &a;
		Console.WriteLine("0x"+&b);
	}
}
