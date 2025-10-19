

//1.  Naive Solution: Below solution will not work for correctly for n = 0 to 12. For n ≥ 13, the factorial result overflows an int in C#.
/*
public class DigitsInFactorial
{
    static int digitsInFactorial(int n)
    {
        // code here
        int fact = 1;

        for (int i = 1; i <= n; i++)
        {
            fact = fact * i;
        }
        int count = 0;
        while (fact > 0)
        {

            count++;
            fact = fact / 10;
        }
        return count;
    }

    public static void main(string[] args)
    {
        int n = 5;
        System.Console.WriteLine("Digits in Factorial are: " + digitsInFactorial(n));
    }
}
*/

/*
OUTPUT: for input 5 factorial is 120 and 
Digits in Factorial are: 3

*/

//------------------------------------------------------------------------------------
//2. Optimize solution

using System;

public class Solution
{
    public int DigitsInFactorial(int n)
    {
        if (n < 0) return 0;
        if (n == 0 || n == 1) return 1;

        double sum = 0;
        for (int i = 2; i <= n; i++)
        {
            sum =sum +  Math.Log10(i); // ✅ Correct method
        }

        return (int)Math.Floor(sum) + 1;
    }

    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        Console.WriteLine("Enter n:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digits in " + n + "! = " + sol.DigitsInFactorial(n));
    }
}
/*
OUTPUT:

Enter n:
19
Digits in 19! = 18
*/