// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class RangeOfPerfectNumber
{
    public static void Main(string[] args)
    {
        //Range
        int range = 100;

        System.Console.WriteLine("Following the list of Perfect number from 1 to " + range);

        //WE are going to check each number if it is perfect or not
        for (int k = 1; k <= range; k++)
        {

            //for each number take sum=0;
            int sum = 0;

            //Divide above each number with from 1 to given number
            for (int i = 1; i <= k / 2; i++)
            {
                //if it is proper divisor keep adding that number
                if (k % i == 0)
                {
                    sum = sum + i;
                }
            }
            //compare if both are matching 
            if (sum == k)
            {
                System.Console.Write(" " + k);
            }


        }

    }
}

/*
OUTPUT:
Following the list of Perfect number from 1 to 100
 6 28
*/