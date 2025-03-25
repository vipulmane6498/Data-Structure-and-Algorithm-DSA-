

//Prime Number
using System;

public class PrimeNumber
{

    public static void Main(string[] arg)
    {

        for (int i = 1; i < 5; i++)
        {
            if (i % 2 == 0)
            {
                System.Console.WriteLine(i + " is prime Not number.");
            }
            else
            {
                System.Console.WriteLine(i + " is prime number.");
            }

        }
        Console.ReadLine();
    }
}