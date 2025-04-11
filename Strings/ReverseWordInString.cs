
//Rverse Word
// Apprach:

// 1. Convert the given string into a character array to modify it in place.
// 2. Reverse individual words in the character array (each word between spaces). (reverseWord : it internally uses reverse method to reverse every character)
// 3. but last word will not reverse becoz there is no space after last word hence reverse it manually by using apply reverse logic method.
// 4. Reverse the entire character array to get the final correct order.
// 5. Print the modified character array as a new string.

//E.g. Welcome to park
// 1. when 1st operation performed : emocleW ot krap
// 2. will reverse entire char array : park to Welcome

using System;
using System.Text.RegularExpressions; // Importing Regex for string manipulation

public class ReverseWordInString
{
    // Method to reverse a portion of the character array between indices 'low' and 'high'
    static void reverse(char[] charArray, int low, int high)
    {
        while (low < high)
        {
            // Swap characters at positions 'low' and 'high'
            char temp = charArray[low];
            charArray[low] = charArray[high];
            charArray[high] = temp;

            // Move towards the center
            low++;
            high--;
        }
    }

    // Function to reverse words in a string
    static void wordReverse(char[] charArray, int n)
    {
        s = Regex.Replace(s.Trim(), @"\s+", " ");// Remove leading and trailing spaces and replace multiple spaces with a single space
        int start = 0; // Start index of a word

        // Step 1: Reverse each word individually
        for (int i = 0; i < n; i++)
        {
            if (charArray[i] == ' ') // Word boundary detected(when space found reverse previous word)
            {
                reverse(charArray, start, i - 1); // Reverse the current word (start->1st char of the word. i-1->last character of the word)
                start = i + 1; // Move start to the next word's 1st character
            }
        }  //1st output: emocleW ot
        //There is no space after last word hence we need to reverse it with reverse method like below
        // Reverse the last word (since it won't be followed by a space)
        reverse(charArray, start, n - 1); //2nd output: krap

        // Step 2: Reverse the entire character array to fix word order
        reverse(charArray, 0, n - 1);//3rd output: park to Welcome
    }

    public static void Main(String[] args)
    {
        string str = "Welcome to Park"; // Input string
        char[] charArray = str.ToCharArray(); // Convert string to character array
        int n = str.Length; // Get the length of the string

        wordReverse(charArray, n); // Call function to reverse words

        // Print the final reversed string
        Console.WriteLine("Reversed string is: " + new string(charArray)); //park to Welcome
    }
}
