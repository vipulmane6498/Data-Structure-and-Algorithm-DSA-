
//Check Anagram: :An anagram is a word or phrase formed by rearranging the letters of another word or phrase, with the same characters appearing the same number of times.
// Approach:
// Step 1: Convert Strings to Lowercase
// Step 2: Convert Strings to Character Arrays

// Step 3: Implement Bubble Sort to Sort the Character Arrays
// a. Outer Loop: Runs for (n-1) passes (since after n-1 passes, the array is sorted).
// b. Inner Loop: Compares adjacent characters and swaps them if they are in the wrong order.
// c. Optimization: The inner loop runs for n - i - 1 iterations to avoid redundant comparisons.

// Step 4: Compare the Sorted Arrays
// Step 5: Print Results








using System;

public class AnagramCheck
{
    public static void Main(String[] args)
    {
        // Define two input strings
        string str1 = "Listen";
        string str2 = "Silent";

        // Convert both strings to lowercase to ensure case insensitivity
        str1 = str1.ToLower();
        str2 = str2.ToLower();

        // Convert strings to character arrays
        char[] firstChar = str1.ToCharArray();
        char[] secondChar = str2.ToCharArray();

        // Sort both character arrays using Bubble Sort
        BubbleSort(firstChar);
        BubbleSort(secondChar);

        // Print sorted versions of both strings
        Console.WriteLine("Sorted string 1: " + new string(firstChar));
        Console.WriteLine("Sorted string 2: " + new string(secondChar));

        // Check if the sorted arrays are equal (i.e., check if they are anagrams)
        bool result = CheckAnagram(firstChar, secondChar);

        // Print result
        Console.WriteLine(result ? "It is an Anagram." : "It is not an Anagram.");
    }

    // Bubble Sort function to sort character array in ascending order
    static void BubbleSort(char[] charArray)
    {
        int n = charArray.Length; // Get the length of the array

        // Outer loop runs for (n-1) passes
        for (int i = 0; i < n - 1; i++)
        {
            // Inner loop for comparison and swapping adjacent elements
            for (int j = 0; j < n - i - 1; j++)
            {
                // Swap if characters are out of order
                if (charArray[j] > charArray[j + 1])
                {
                    char temp = charArray[j];
                    charArray[j] = charArray[j + 1];
                    charArray[j + 1] = temp;
                }
            }
        }
    }

    // Function to check if two sorted character arrays are anagrams
    static bool CheckAnagram(char[] firstChar, char[] secondChar)
    {
        // If lengths are different, they can't be anagrams
        if (firstChar.Length != secondChar.Length)
        {
            return false;
        }

        // Compare each character in the sorted arrays
        for (int i = 0; i < firstChar.Length; i++)
        {
            if (firstChar[i] != secondChar[i])
            {
                return false; // If any character differs, they are not anagrams
            }
        }

        return true; // If all characters match, they are anagrams
    }
}
