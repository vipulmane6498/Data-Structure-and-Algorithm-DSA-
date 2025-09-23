/*
Decimal to Octal Conversion:
📌 What is an Octal Number?

An Octal Number is a number in base 8.
It only uses digits from 0 to 7.
Each place value is a power of 8 (just like in decimal each place value is a power of 10).

👉 Example:
Decimal 56 → Octal?
Divide 56 by 8 → quotient = 7, remainder = 0
Divide 7 by 8 → quotient = 0, remainder = 7
Write remainders from bottom to top → 70

​
📌 Approach of the Code
1. Input the number from user (in decimal).
2. Store a copy of that number (to print later).
3. Use a loop to divide the number by 8 repeatedly until it becomes 0.
    3.1 Each time, find the remainder (num % 8).
    3.2 Add this remainder in front of the octal string.
    3.3 Update number as num = num / 8.
4. When the loop ends, the collected string will be the octal number.
5. Finally, print the result.
*/

using System;

public class DecimalToOctal
{
    public static vomid Main(string[] args)
    {
        // Ask the user to enter a number
        System.Console.WriteLine("Enter a number to see its Octal Number: ");

        // Read the number from user as string, then convert it into integer
        int num = Convert.ToInt32(System.Console.ReadLine());

        // Save the original number in another variable (x) 
        // because we will change 'num' during calculation
        int x = num;

        // This will store the final octal number as text (string)
        string octal = "";

        // Repeat until num becomes 0
        while(num > 0)
        { 
            // Find remainder when dividing by 8
            int remainder = num % 8;

            // Add remainder in front of the current octal string
            // Example: if octal = "2" and remainder = 7, new octal = "72"
            octal = remainder + octal;

            // Divide the number by 8 for next step
            num = num / 8;
        }
        
        // Print the octal number of the given number
        System.Console.WriteLine("The octal number for given number " + x + " is: " + octal);
    }
}

/*
SAMPLE OUTPUT:
Enter a number to see its Octal Number: 
56
The octal number for given number 56 is: 70
*/
