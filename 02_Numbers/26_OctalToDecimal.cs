/*
Octal to Decimal Conversion:
We will take an Octal number (base 8) from user 
and convert it into Decimal number (base 10).

e.g. octal 70 → decimal 56

📌 Approach of the Code

1. Input the Octal Number
    1.1 Take an octal number (base 8) as input from the user.
    1.2 Example: user enters 70.
2. Initialize Variables
    2.1 decimals = 0 → will store the final decimal number.
    2.2 count = 0 → keeps track of the digit position (power of 8).
3. Process Each Digit (Right to Left)
    3.1 Use a while loop until the number becomes 0.
    3.2 Take the last digit of the octal number using % 10.
    3.3 Multiply this digit by 8^count (power of 8 depending on its position in the number).
    3.4 Add the result to decimals.
    3.5 Increase count by 1.
    3.6 Remove the last digit using / 10.
4. Repeat until all digits are processed.
5. Output the Result
    5.1 Finally, print the decimal equivalent of the original octal number.

📌 Example (Octal: 70 → Decimal: 56)
Start: num = 70, decimals = 0, count = 0
Step 1: Last digit = 0 → 0x8^0, decimals = 0, count=0
Step 2: Next digit = 7 → 7x8^1=56, decimals =56, count=1
Done → Decimal = 56

👉 In short:
We break octal into digits, multiply each digit with the corresponding power of 8, and add them up to get the decimal number.
*/

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Ask the user to enter an octal number
        System.Console.WriteLine("Enter an octal number to see its Decimal Number: ");
        
        // Read the number as integer (for example: 70 in octal)
        int num = Convert.ToInt32(System.Console.ReadLine());
        
        // Keep a copy of the original number (for printing at the end)
        int x = num;

        // This will store the final decimal value
        int decimals = 0;

        // This variable tells us which position (power of 8) we are at
        int count = 0;
       
        // Loop until number becomes 0
        while(num > 0)
        {
            // Get the last digit of the number
            int remainder = num % 10;

            // Convert this digit into decimal by multiplying with 8^count
            // Example: for octal "70" → first digit 0 * 8^0, next digit 7 * 8^1
            decimals = decimals + remainder * pow(8, count);

            // Increase the power counter
            count++;

            // Remove the last digit from the number
            num = num / 10;
        }
       
        // Print the result
        System.Console.WriteLine("The decimal number for given octal " + x + " is: " + decimals);
    }
    
    // This method calculates power (n^count)
    // Example: pow(8,2) = 8*8 = 64
    static int pow(int n, int count)
    {
        int pw = 1;

        // Multiply 'n' with itself 'count' times
        while(count > 0)
        {
            pw = pw * n;
            count--;
        }
        return pw;
    }
}

/*
SAMPLE OUTPUT:
Enter an octal number to see its Decimal Number: 
70
The decimal number for given octal 70 is: 56
*/
