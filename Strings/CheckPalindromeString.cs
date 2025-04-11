
// Approach to Solve palindrome problem
// Understanding a Palindrome
// A palindrome is a string that reads the same forward and backward (e.g., "madam", "racecar").

// Algorithm:
// 1. Use the two-pointer technique:
// One pointer starts from the beginning (begin = 0).
// Another pointer starts from the end (end = str.Length - 1).
// 2. Compare characters at these positions:
// If characters don’t match, return false (not a palindrome).
// If they match, move both pointers toward the center.
// 3. If all characters match, return true (it's a palindrome).
using System;

public class CheckPalindromeString
{
    public static void Main(String[] args)
    {
        // Define the input string to check for palindrome
        string str = "aabbccbbaa";
        
        // Call the function to check if the string is a palindrome
        bool output = checkPalindrome(str);
        
        // Print the result (true if palindrome, false otherwise)
        Console.WriteLine(output);
    }

    // Function to check if a string is a palindrome
    static bool checkPalindrome(string str)
    {
        int begin = 0;               // Pointer at the start of the string
        int end = str.Length - 1;    // Pointer at the end of the string

        // Loop until the pointers meet in the middle
        while (begin < end)
        {
            // If characters at the current positions are not the same, return false
            if (str[begin] != str[end])
            {
                return false;  // Not a palindrome
            }
            
            // Move pointers towards the center
            begin++;
            end--;
        }

        // If all character comparisons passed, it's a palindrome
        return true;
    }
}

//True