// DECIMAL to	ALL(Octal, Hexa and Binary) conversion in single problem in c#:
// Approach of the code:
// 1. Take a decimal number and a base (2, 8, 16, etc.) as input from the user.
// 2. Use repeated division by the base to find remainders.
// 3. Map each remainder to its corresponding digit/letter (0–9, A–F).
// 4. Build the new number representation by appending remainders in reverse order.
// 5. Print the number in the chosen base.

// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class DecimalToBinaryOctalHexadecimal
{
    public static void Main(string[] args)
    {
        // Prompt user to enter a number in decimal
        System.Console.WriteLine("Enter a number: ");
        int num = Convert.ToInt32(System.Console.ReadLine());

        // Prompt user to enter the base (e.g., 2 for binary, 8 for octal, 16 for hex)
        System.Console.WriteLine("Enter a base: ");
        int bas = Convert.ToInt32(System.Console.ReadLine());

        // String containing possible digits (0–9 + A–F for hexadecimal)
        string st = "0123456789ABCDEF";

        // String to store the converted number
        string b = "";

        // Repeat until the number becomes 0
        while (num > 0)
        {
            // Find remainder when divided by base
            int remainder = num % bas;

            // Get corresponding digit from st and add it to the left of result string
            b = st[remainder] + b;

            // Update number by dividing it by base
            num = num / bas;
        }

        // Print the final result in the selected base
        System.Console.WriteLine(bas + " base equivalent: " + b);
    }
}

/*
OUTPUT->

Enter the number: 469
Enter the base: 16
16 base equivalent: 1D5  -> Hexadecimal number

Enter the number: 369
Enter the base: 8
8 base equivalent: 561   -> Octal number

Enter the number: 50
Enter the base: 2
2 base equivalent: 110010 -> Binary number
*/
