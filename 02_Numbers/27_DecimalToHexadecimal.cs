/*
Convert Decimal to Hexadecimal:

A hexadecimal number (often called hex) is a number system that uses base 16.

That means it has 16 unique digits:
0, 1, 2, 3, 4, 5, 6, 7, 8, 9, A, B, C, D, E, F
The digits 0–9 represent the values 0 to 9.
The letters A–F represent the values 10 to 15.

Examples:
Hex A = Decimal 10
Hex 1F = Decimal 31 (since 1×16 + 15 = 31)
Hex FF = Decimal 255 (15×16 + 15 = 255)

Why we use hexadecimal:
Computers work with binary (base 2) numbers (only 0 and 1).
Hexadecimal is a shorter, human-friendly way of writing binary.
Example: Binary 11111111 = Hex FF

👉 It’s widely used in programming, memory addresses, colors (HTML/CSS like #FF0000 for red), and low-level computing.

Approach:
🔹 Approach to Convert Decimal → Hexadecimal (Your Code)

Take a decimal number

Example: 469

Initialize an empty string hex

This will hold the final hexadecimal result.

Loop until the number becomes 0

In each step:

Find the remainder when dividing by 16 (remainder = num % 16)

Because hexadecimal has base 16, each remainder gives one hex digit.

Convert this remainder into a hex digit:

If remainder is 0–9 → use the same digit.

If remainder is 10–15 → map to letters A–F.

Add this digit in front of the current hex string (because the first remainder gives the last digit).

Update the number

Divide the number by 16 (num = num / 16)

This shifts the process to the next digit.

Repeat until num = 0

Once finished, hex contains the hexadecimal representation.

Print the result

Example: 469 → 1D5

🔹 Example Walkthrough (469)

Start: num = 469, hex = ""

469 % 16 = 5 → remainder = 5 → hex = "5"
Update num = 469 / 16 = 29

29 % 16 = 13 → remainder = 13 → hex digit = "D"
Add in front → hex = "D5"
Update num = 29 / 16 = 1

1 % 16 = 1 → remainder = 1 → hex = "1D5"
Update num = 1 / 16 = 0

Loop ends → Final hex = 1D5
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Start with a decimal number
        int num = 469;

        // Keep a copy of the original number for display later
        int x = num;

        // Variable to build the hexadecimal string
        string hex = "";
        
        // Repeat until the number becomes 0
        while (num > 0)
        {
            // Find the remainder when dividing by 16
            int remainder = num % 16;
            
            // Convert remainder into corresponding hex character
            switch (remainder)
            {
                case 10: 
                    hex = 'A' + hex;
                    break;
                    
                case 11: 
                    hex = 'B' + hex;
                    break;
                    
                case 12: 
                    hex = 'C' + hex;
                    break;
                    
                case 13: 
                    hex = 'D' + hex;
                    break; 
                    
                case 14: 
                    hex = 'E' + hex;
                    break; 
                    
                case 15: 
                    hex = 'F' + hex;
                    break;
                    
                default:
                    // For remainders 0–9, just add the digit directly
                    hex = remainder + hex;
                    break;
            }
            
            // Divide the number by 16 to move to the next digit
            num = num / 16;
        }

        /*
            🔹 Example Walkthrough (469)

            Start: num = 469, hex = ""

            469 % 16 = 5 → remainder = 5 → hex = "5"
            Update num = 469 / 16 = 29

            29 % 16 = 13 → remainder = 13 → hex digit = "D"
            Add in front → hex = "D5"
            Update num = 29 / 16 = 1

            1 % 16 = 1 → remainder = 1 → hex = "1D5"
            Update num = 1 / 16 = 0

            Loop ends → Final hex = 1D5
        */
        
        // Print the result
        System.Console.WriteLine("For given number " + x + " hexadecimal is: " + hex);
    }
}
/*
OUTPUT:
For given number 469 hexadecimal is: 1D5
*/