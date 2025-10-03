
//hexadecimal to Decimal Conversion in C#->
// Approach of the code:
// 1. Take a hexadecimal number as input (string).
// 2. Traverse the string from right to left (least significant digit first).
// 3. Convert each character into its decimal value (0–9, A–F, a–f).
// 4. Multiply each digit’s value with 16^position and add it to the result.
// 5. Print the final decimal equivalent.



using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Ask user to enter a hexadecimal number
        System.Console.WriteLine("Enter a Hexadecimal number to see it in Decimal number: ");
        
        // Read user input as string
        string st = System.Console.ReadLine();
        // string st="1D5";   // You can hardcode input for testing
        
        // Get the length of the string (number of characters in hexadecimal input)
        int length = st.Length;
        
        // Variable to store the final decimal value
        int decimals = 0;
        
        // Counter to keep track of the power of 16 (position of digit)
        int count = 0;
        
        // Loop through the hexadecimal string from right to left
        while (length > 0)
        {
            int r = 0; // Variable to store decimal equivalent of single hex character
            
            // Get the last character from the string
            char ch = st[length - 1];
            
            // If character is between 'A' (65) and 'F' (70)
            if (ch >= 65 && ch <= 70)
            {
                r = ch - 55; // Example: 'A'(65) - 55 = 10
            }
            // If character is between 'a' (97) and 'f' (102)
            else if (ch >= 97 && ch <= 102)
            {
                r = ch - 87; // Example: 'a'(97) - 87 = 10
            }
            // Else it is a digit between '0'–'9'
            else
            {
                r = ch - 48; // Example: '5'(53) - 48 = 5
            }
            
            // Add contribution of current digit to decimal result
            decimals = decimals + r * pow(16, count);
            
            // Increase power counter for next iteration
            count++;
            
            // Decrease length to move leftwards in the string
            length--;
        }
        
        // Print the final result
        System.Console.WriteLine("The Decimal number for given Hexadecimal number: " + st + " is: " + decimals);
    }
    
    // Custom power function: calculates n^count
    static int pow(int n, int count)
    {
        int pw = 1; // Initialize result
        while (count > 0)
        {
            pw = pw * n; // Multiply n each time
            count--;     // Decrease exponent counter
        }
        return pw; // Return result
    }
}

/*
OUTPUT->
Enter a Hexadecimal number to see it in Decimal number: 
1D5
The Decimal number for given Hexadecimal number: 1D5 is: 469
*/
