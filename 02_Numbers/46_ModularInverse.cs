/*
Program to find Modular Multiplicative Inverse
For a given number `n` and modulus `m`, modular inverse is a number `x`
such that: (n * x) % m = 1
Explain: I want the smallest number that, when multiplied with n and taken modulo m, gives a remainder of 1; otherwise return -1.”

Example 1:
Input: n = 3, m = 11
Output: 4
Explanation: Since (4 × 3) mod 11 = 1, 4 is the modulo inverse of 3 under mod 11.

Example 2:
Input: n = 10, m = 17
Output: 12
Explanation: Since (12*10) mod 17 = 1, 12 is the modulo inverse of 10.

*/

using System;

public class ModularInverse
{
    public static void Main(string[] args)
    {
        // Given values
        int n = 3;   // Number whose modular inverse we want
        int m = 11;  // Modulus value

        // Call method to calculate modular inverse
        int mod = modInverse(n, m);

        // Print the result
        System.Console.WriteLine("Modular Inverse is:  " + mod);
    }
 
    // Function to find modular inverse of n under modulo m
    static int modInverse(int n, int m) 
    {
        // Try all possible values of i from 1 to m
        for (int i = 1; i <= m; i++) 
        {
            // If (n * i) % m == 1, then i is the modular inverse
            if ((n * i) % m == 1) 
            {
                return i; // Return the modular inverse
            }
        }

        // If no modular inverse exists, return -1
        return -1;
    }
}

/*
OUTPUT:
Modular Inverse is: 4


*/
