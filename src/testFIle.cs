using System;

public class TestClass {
    public static void Main(String [] args) {
        Console.WriteLine("Hello World!");
        pointerTest();
    }

    public unsafe static void pointerTest() {
        int a = 5;
        int* b = &a;
        Console.WriteLine("0x"+b);

    }
}