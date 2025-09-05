/*
Range of ArmStrong number: 

Approach:
Armstrong number → A number is Armstrong if
sum of each digit raised to the power of total digits = original number.
Example:
153 → 1³ + 5³ + 3³ = 153 ✅
9474 → 9⁴ + 4⁴ + 7⁴ + 4⁴ = 9474 ✅

Program steps:
User enters a number (say 500).
Program checks each number from 0 to 500.
If it is Armstrong, it prints it.

Functions used:
CountDigit() → counts number of digits.
Pow() → calculates power (like 3³ = 27).
IsArmstrong() → checks Armstrong logic.
*/


using System;

public class RangeOfArmstrongNumber
{
    public static void Main(string[] args)
    {
        // Ask the user to enter a number
        Console.WriteLine("Enter the number: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Loop from 0 to the entered number
        for (int i = 0; i <= n; i++)
        {
            // Check if the current number i is Armstrong
            bool r = IsArmstrong(i);

            // If yes, print it
            if (r)
            {
                Console.WriteLine(i + " is Armstrong");
            }
        }
    }

    // Method to count digits in a number
    static int CountDigit(int num)
    {
        int count = 0;
        while (num > 0)
        {
            count++;          // Increase count for each digit
            num = num / 10;   // Remove the last digit
        }
        return count;
    }

    // Method to calculate power (n^p)
    static int Pow(int n, int p)
    {
        int pw = 1;
        while (p > 0)
        {
            pw = pw * n;  // Multiply n again and again
            p--;          // Decrease power count
        }
        return pw;
    }

    // Method to check if a number is Armstrong
    static bool IsArmstrong(int x)
    {
        int nd = CountDigit(x); // Count how many digits are in number
        int t = x;              // Copy number
        int sum = 0;

        while (t > 0)
        {
            int r = t % 10;               // Get last digit
            sum = sum + Pow(r, nd);       // Add (digit ^ numberOfDigits) to sum
            t = t / 10;                   // Remove last digit
        }

        // If sum is equal to original number, it is Armstrong
        if (sum == x)
            return true;
        else
            return false;
    }
}

/*
OUTPUT:
Enter the number: 
300
0 is Armstrong
1 is Armstrong
2 is Armstrong
3 is Armstrong
4 is Armstrong
5 is Armstrong
6 is Armstrong
7 is Armstrong
8 is Armstrong
9 is Armstrong
153 is Armstrong
*/