
/*

LCM: The LCM of two (or more) numbers is the smallest positive number that is a multiple of all the given numbers.

Example
For 4 and 6:
Multiples of 4: 4, 8, 12, 16, 20, 24, ...
Multiples of 6: 6, 12, 18, 24, 30, ...
The common multiples are: 12, 24, 36, ...
The smallest common multiple is 12 → LCM(4, 6) = 12.

Appoach:

Understand the relationship:
The mathematical formula to find LCM is:
mathematica
Copy
Edit
LCM(a, b) = (a × b) / GCD(a, b)
This works because the product of two numbers is always equal to the product of their GCD and LCM.

Find GCD using the Euclidean Algorithm:
If b is 0, then a is the GCD.
Otherwise, recursively call GCD(b, a % b) until b becomes 0.

Use GCD to get LCM:
Multiply a and b.
Divide the result by their GCD to get the LCM.

Display the result:
Call the lcm() method with given a and b and print the value.

*/

using System;

class GFG
{
    // Method to find GCD (Greatest Common Divisor) using Euclidean Algorithm
    static int gcd(int a, int b)
    {
        // Base case: If b becomes 0, a is the GCD
        if (b == 0)
            return a;

        // Recursive call: GCD of (b, remainder of a divided by b)
        return gcd(b, a % b);
    }

    // Method to find LCM (Least Common Multiple) using the formula:
    // LCM(a, b) = (a * b) / GCD(a, b)
    static int lcm(int a, int b)
    {
        return (a * b) / gcd(a, b);
    }

    public static void Main (string[] args) 
    {
        // Declare two integers
        int a = 4, b = 6;

        // Print the LCM of a and b
        Console.WriteLine(lcm(a, b)); // Output: 12
    }
}
/*
OUTPUT:
12
*/