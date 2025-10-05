/*

GCD (Greatest Common Divisor):

The GCD of two numbers is the largest positive integer that divides both numbers without leaving a remainder.
It is also known as HCF (Highest Common Factor).

We have two solutions to find the GCD of two numbers:

1. Naice Solution -> Brute Force Method (or Iterative Search Method)

2. Efficient Solution -> Using the Euclidean algorithm:
   - This method is efficient and works by repeatedly replacing the larger number by the remainder of the division of the two numbers until one of them becomes zero.
   - The other number at that point will be the GCD.

*/

//1. Naive Solution: Brute Force Method
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Declare two numbers
        int a = 100;
        int b = 200;

        // Variable to store the starting point for checking
        int start;

        // Find the smaller number (GCD will never be larger than the smaller number)
        if (a < b)
        {
            start = a;
        }
        else
        {
            start = b;
        }

        // Loop from the smaller number down to 1
        for (int i = start; i >= 1; i--)
        {
            // Check if 'i' is a divisor of both a and b
            if (a % i == 0 && b % i == 0)
            {
                // Found the greatest common divisor (GCD)
                Console.WriteLine("Greatest Common Divisor is: " + i);

                // Exit loop after finding the first (largest) divisor
                break;
            }
        }
    }
}

/*
OUTPUT:
Greatest Common Divisor is: 100
*/

//-------------------------------------------------------------------------------------------------------

//2. Efficient Solution: Using the Euclidean Algorithm

/*
using System;

class GFG
{
    // Method to find GCD (Greatest Common Divisor) of two numbers using recursion
    static int gcd(int a, int b)
    {
        // Base condition: if second number becomes 0, first number is the GCD
        if (b == 0)
            return a;

        // Recursive call: GCD of (b, remainder of a divided by b)
        return gcd(b, a % b);
    }

    public static void Main (string[] args) 
    {
        // Declare two integers
        int a = 12, b = 15;

        // Print the GCD of a and b
        Console.WriteLine(gcd(a, b)); // Output will be 3
    }
}
*/
/*
OUTPUT:
3
*/