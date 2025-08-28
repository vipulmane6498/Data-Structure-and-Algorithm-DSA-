// Level - Easy
//Program to check if a number is a Palindrome
// A palindrome number reads the same forward and backward.

// Approach:
// Step 1: Reverse the given number.
// Step 2: Compare the reversed number with the original number.

using System;

public class Palindrome {
    public static void Main(String[] args) {
        
        // Prompt the user to enter a number
        System.Console.WriteLine("Enter a number to check if it is a palindrome: ");
        
        // Read the user input and convert it to an integer
        int num = Convert.ToInt32(System.Console.ReadLine());
        
        // Variable to store the reversed number
        int reverse = 0;
        
        // Store the original value of num in 'a' because num will change in the process
        int a = num;
        
        // Loop to reverse the digits of the number
        while (num > 0) { 
            int digit = num % 10; // Extract the last digit of the number
            reverse = (reverse * 10) + digit; // Append the digit to the reverse variable
            num = num / 10; // Remove the last digit from num. It refers the quetiont 
        }

        // Check if the reversed number is the same as the original number
        if (reverse == a) {
            System.Console.WriteLine(a + " is a palindrome number."); // Palindrome case
        } else {
            System.Console.WriteLine(a + " is not a palindrome number."); // Not a palindrome case
        }
    }
}

/*
Enter a number to check if it is palindrome: 
121
121 is palindrome Number.
*/
