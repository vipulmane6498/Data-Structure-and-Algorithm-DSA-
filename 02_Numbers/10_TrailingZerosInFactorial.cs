/*
Trailing Zeros In Factorial:

Approach:

Understand the problem

Trailing zeros in n! (factorial of n) come from multiplying 2 × 5 = 10.

There are always more 2s than 5s in the factorial, so we just count the number of 5s in the prime factors of all numbers from 1 to n.

Count how many times 5 divides the numbers

For example, in 10!, numbers like 5 and 10 contribute at least one 5.

Numbers like 25, 125, etc., contribute more than one 5.

Use a loop

Start with i = 5, then i = 25, then i = 125, and so on.

For each i, do n / i and add it to the result.

Print the result

That’s the count of trailing zeros in n!.

InShort -> I will try to devide given same number by 5, 25, 125, etc., until it becomes zero. and its quotient will be added to the result.

Example for n = 10:
    10 / 5 = 2
    10 / 25 = 0 → stop
    So, trailing zeros in 10! = 2

*/

using System;

public class TrailingZerosInFactorial
{
    public static void Main(string[] args)
    {
        // Define the number for which we want to find factorial trailing zeros
        int n = 251;

        // Variable to store count of trailing zeros
        int res = 0;

        // Loop to count number of times 5 (and its powers) divide into n
        // This is because trailing zeros are created by multiples of 10 (i.e., 2 × 5)
        for (int i = 5; i <= n; i = i * 5)
        {
            res = res + (n / i); // Add count of multiples of 5, 25, 125, etc.
        }

        // Output the result
        System.Console.WriteLine("Trailing Zeros are: " + res);
    }
}
/*
OUTPUT:
Trailing Zeros are: 62

*/
