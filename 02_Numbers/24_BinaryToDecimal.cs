/*
Binary to Decimal:

🔹 Approach (Binary → Decimal Conversion)

Take the binary number as input.
    Example: 111100001111
Start from the last digit (rightmost) of the binary number.
    Keep a counter (count) to know which position (power of 2) we are at.
Extract the last digit using % 10.
    Example: 111100001111 % 10 = 1
Multiply the digit with 2^count and add to the answer.
    Example: 1 * 2^0 = 1
Increase the counter (count++) to move to the next digit.
Remove the last digit by dividing the number by 10.
    Example: 111100001111 / 10 = 11110000111
Repeat steps 3–6 until the number becomes 0.
The result stored in decimals is the decimal value of the binary number.

*/


using System;

public class BinaryToDecimal
{
    public static void Main(string[] args)
    {
        // Start with a binary number (here we take 111100001111)
        long num = 111100001111;

        // Keep original number safe (to print later)
        long x = num;

        // This will store the final decimal answer
        long decimals = 0;

        // This will count the position (power of 2)
        int count = 0;

        // Repeat until binary number becomes 0
        while (num > 0)
        {   //we are traversing from last digit to 1st digit(indexing => n <- 2,1,0) in binary number 111100001111
            // Get the last digit (either 0 or 1)
            long remainder = num % 10;

            // Multiply the digit with 2^count and add to answer
            decimals = decimals + remainder * pow(2, count);

            // Move to the next position (increase power of 2)
            count++;

            // Remove the last digit (shift right in binary)
            num = num / 10;
        }
        /*
        breakdown:
        🔹 Example Walkthrough (111100001111 → Decimal)
            Binary: 111100001111
            Step 1: last digit = 1 → 1 * 2^0 = 1 → sum = 1
            Step 2: next digit = 1 → 1 * 2^1 = 2 → sum = 3
            Step 3: next digit = 1 → 1 * 2^2 = 4 → sum = 7
            Step 4: next digit = 1 → 1 * 2^3 = 8 → sum = 15
            Step 5: next digit = 0 → 0 * 2^4 = 0 → sum = 15
            Step 6: next digit = 0 → 0 * 2^5 = 0 → sum = 15
            Step 7: next digit = 0 → 0 * 2^6 = 0 → sum = 15
            Step 8: next digit = 0 → 0 * 2^7 = 0 → sum = 15
            Step 9: next digit = 1 → 1 * 2^8 = 256 → sum = 271
            Step 10: next digit = 1 → 1 * 2^9 = 512 → sum = 783
            Step 11: next digit = 1 → 1 * 2^10 = 1024 → sum = 1807
            Step 12: next digit = 1 → 1 * 2^11 = 2048 → sum = 3855 
            final => 3855
        */

        // Show the decimal number
        Console.WriteLine("Decimal number for given binary " + x + " is: " + decimals);
    }

    // Function to calculate power (n^count)
    static int pow(int n, int count)
    {
        int pw = 1;

        // Multiply n with itself 'count' times
        while (count > 0)
        {
            pw = pw * n;
            count--;
        }

        return pw; // return the final answer
    }
}
/*
OUTPUT:
Decimal number for given binary 111100001111 is: 3855

*/