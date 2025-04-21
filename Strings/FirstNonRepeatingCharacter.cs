
// Problem -> First Non Repeating Character/First Unique Character in a String - Easy

// Approach:
// For each character in the string (outer loop),
// You compare it with every other character (inner loop),
// If a duplicate is found (same character at different index), it's marked as repeating.
// The first character that does not repeat is printed and the program exits.



using System;

class FirstNonRepeatingCharacter {
    
    public static void Main(String[] args) {
        
        // Input string
        string str = "abababbxab";

        // Convert the string to a character array
        char[] newArr = str.ToCharArray();

        // Get the length of the array
        int n = newArr.Length;

        // Outer loop to check each character one by one
        for (int i = 0; i < n; i++) {
            // Flag to check if character is repeating(if true -> matching or false -> not matching and return that character)
            bool flag = false;

            // Inner loop to compare current character with all others
            for (int j = 0; j < n; j++) {
                // i!=j => outer and innner loop should not compare the same indexing char.
                // //If characters match and it's not the same position, it's a repeat
                if (i != j && newArr[i] == newArr[j]) {
                    flag = true; // Mark as repeating
                    break;       // Exit inner loop
                }
            }

            // If no match was found (i.e., character is unique)
            if (flag == false) {
                // Print the first non-repeating character
                Console.WriteLine("First non-repeating character: " + newArr[i]);
            }
        }

        // If all characters are repeating
        Console.WriteLine("No non-repeating character found.");
    }
}
