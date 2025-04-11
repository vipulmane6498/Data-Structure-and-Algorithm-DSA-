//Leftmost Non repeating character index

// Approach:
// 1. Loop through each character: Iterate through each character of the string to check if it is a non-repeating character.

// 2. Check for repetition: For each character, compare it with all subsequent characters in the string.

// 3. Flag variable: Use a flag to track if the current character repeats.

// 4. If a repeat is found, set the flag to true and break out of the inner loop.

// 5. If the flag remains false after checking all subsequent characters, it means the character is non-repeating.

// 6. Return the index: As soon as a non-repeating character is found, return its index.

// 7. If no non-repeating character: If no non-repeating character is found, return -1.



using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Input string where we need to find the leftmost non-repeating character
        string s1 = "aabcde";
        
        // Call the NonRepeating function to find the leftmost non-repeating character's index
        int result = NonRepeating(s1);
        
        // Output the result to the console
        System.Console.WriteLine("Leftmost Non-repeating Character's index is: " + result);
    }

    static int NonRepeating(string s1)
    {
        int m = s1.Length;  // Get the length of the string
        
        // Iterate through each character in the string
        for (int i = 0; i < m; i++)
        {
            bool flag = false;  // Flag to track if the current character repeats

            // Compare the current character with all subsequent characters
            for (int j = 0; j < m; j++)
            {
                // Skip comparing the character with itself (i != j) and check if they are equal
                if (i != j && s1[i] == s1[j])
                {
                    flag = true;  // If a repeat is found, set flag to true
                    break;  // Exit the inner loop early as we don't need to check further
                }
            }
            
            // If flag is still false after checking all subsequent characters, 
            // it means the character at index 'i' is non-repeating.
            if (flag == false)
            {
                return i;  // Return the index of the first non-repeating character
            }
        }
        
        // If no non-repeating character is found, return -1
        return -1;
    }
}
/*
Leftmost Non-repeating Character's index is: 2
*/