/* Level - Easy
Count Digits For Number:

Approach:
1. Input a number from the user.
2. Initialize a count = 0.
3. Loop:
    3.1 While number > 0:
    3.2 Divide by 10 (remove last digit)
    3.4 Increment count
4. Print the digit count.


*/


using System;

// Define a class named CountDigitsForNumber
public class CountDigitsForNumber
{
    // Main method: entry point of the program
    public static void Main(string[] args)
    {
        // Ask user to enter a number
        System.Console.WriteLine("Enter a number: ");

        // Read input from user and convert it to integer
        int x = Convert.ToInt32(System.Console.ReadLine());

        // Store original number in 'y' for displaying later
        int y = x;

        // Initialize count variable to 0 to store number of digits
        int count = 0;
        
        // Loop to count digits: divide the number by 10 until it becomes 0
        while(x > 0)
        {
            x = x / 10;   // Remove last digit
            count++;      // Increase digit count
        }

        // Display the original number and its digit count
        System.Console.WriteLine("For given number: " + y + " Count of Digit is: " + count);
    }
}
/*
OUTPUT:

Enter a number: 
45789
For given number: 45789 Count of Digit is: 5


*/