using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.Write("Hello, ");
        Console.WriteLine("World!");
        
        float floatSayi = 12.1f;
        int intSayi = 124;
        Console.WriteLine(floatSayi);
        Console.WriteLine(intSayi); //124

        Console.WriteLine(intSayi++); //124
        Console.WriteLine(++intSayi); //126
        Console.WriteLine(5 < 1); //false
        Console.ReadKey();
    }
}
