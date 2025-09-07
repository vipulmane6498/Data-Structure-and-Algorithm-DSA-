/*
Strong Number -> A number is called a Strong Number if
the sum of the factorial of its digits is equal to the number itself.

Example: 145
1! = 1
4! = 24
5! = 120
Sum = 1 + 24 + 120 = 145
Since sum == original number, 145 is a Strong Number.
*/

using System; // Import System library (needed to use Console for printing)

public class RangeOfStrongNumber
{
    public static void Main(string[] args)
    {
        int range = 1000;   // We will check numbers from 1 to 1000

        // Print a message to tell user what we are going to do
        Console.WriteLine("Following is the Range of Strong numbers till given number " + range);

        // Loop through each number from 1 to 1000
        for (int i = 1; i <= range; i++)
        {
            int x = i;       // Keep a copy of the original number
            int num = i;     // Copy used to extract digits
            int sum = 0;     // To store sum of factorials of digits

            // Extract digits one by one
            while (num > 0)
            {
                int remainder = num % 10;           // Get last digit (e.g. 145 % 10 = 5)
                sum = sum + Factorial(remainder);   // Add factorial of that digit to sum
                num = num / 10;                     // Remove last digit (e.g. 145 / 10 = 14)
            }

            // If sum of factorials equals the original number, it is a Strong Number
            if (x == sum)
            {
                Console.Write(x + " ");  // Print the number in same line separated by spaces
            }
        }
    }

    // Method to calculate factorial of a digit
    // Example: if n = 5 → factorial = 5*4*3*2*1 = 120
    static int Factorial(int n)
    {
        int fact = 1;                    // Start with 1
        for (int i = 1; i <= n; i++)
        {     // Multiply numbers from 1 to n
            fact = fact * i;
        }
        return fact;                     // Return the factorial value
    }
}
/*
Following is the Range of Strong numbers till given number 1000
1 2 145 

*/
