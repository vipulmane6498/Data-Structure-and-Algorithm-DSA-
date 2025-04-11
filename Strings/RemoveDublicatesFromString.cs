
// Remove Duplicates character from string
// Approach
// 1️⃣ Convert String to Character Array   
//  Create a Result Array for Unique Characters
//   Iterate Over Each Character in the Input String
//   4️⃣ Check for Duplicates- if found break the look
//   5️⃣ Store Unique Characters
//   6️⃣ Convert the Result Array to a String
using System;

public class RemoveDuplicatesFromString {
    
    static void Main(string[] args) {
        string str = "abacb"; // Input string with duplicates

        char[] charArray = str.ToCharArray(); // Convert string to character array
        int n = charArray.Length; // Fix: Use full length

        char[] chat = new char[n]; // Fix: Correct array size
        int res = 0; // Keeps track of unique character count for chat char array

        for (int i = 0; i < n; i++) {
            bool isDuplicate = false; //consider first

            // Check if the character is already present in `chat`
            for (int j = 0; j < res; j++) { // Fix: Loop only up to `res`
                if (charArray[i] == chat[j]) {
                    isDuplicate = true;
                    break; // Exit loop early if duplicate found
                }
            }

            // If not a duplicate, add to `chat`
            if (isDuplicate==false) {
                chat[res] = charArray[i];
                res++;
            }
        }

        // Convert unique characters back to a string
        string s = new string(chat, 0, res); 
        System.Console.WriteLine("String after removing duplicates: " + s);
    }
}
