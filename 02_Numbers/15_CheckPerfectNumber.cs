/*
Perfect Number: A positive integer that is equal to the sum of its proper divisors. 
The smallest perfect number is 6, which is the sum of 1, 2,	and	3.

*/

using System;

public class CheckPerfectNumber
{
    public static void Main(string[] args)
    {
        int num = 66;

        int sum = 0;
        for (int i = 1; i <= num / 2; i++)
        {
            if (num % i == 0)
            {
                sum = sum + i;
            }
        }
        if (sum == num)
        {
            System.Console.WriteLine("Given number " + num + " is Perfect Number !");
        }
        else
        {
            System.Console.WriteLine("Given number " + num + " is NOT Perfect Number !");

        }
    }
}
/*
Given number 6 is Perfect Number !
*/