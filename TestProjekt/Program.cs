using System;

class Program
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static void Main()
    {
        int result = Add(2, 3);

        if (result == 5)
        {
            Console.WriteLine("OK");
        }
        else
        {
            Console.WriteLine("FEHLER");
            
        }

        Console.ReadLine();

    }
}