
/*
Pattern Searching in C#: 
// This code performs pattern searching in a string. It checks for all occurrences of a pattern in a given string and prints the starting index of each occurrence.

Approach:

1. Inputs:
  a. first: The main string
  b. second: The pattern to search

2. Loop through first:
  a. For each index i, check if second matches first starting from i.

3. Inner comparison:
  a. Compare characters of second with substring in first.
  b. Break if any character doesn’t match.

4. If full match (j == n):
  a. Print the starting index i.

5. Output:
  a. All starting indices where the pattern is found.

*/





If full match (j == n):

Print the starting index i.

Output:

All starting indices where the pattern is found.


using System;

class MainClass {
  // Function to perform pattern searching
  public static void patSearching(string first, string second) {
    int m = first.Length; // Length of the first string
    int n = second.Length; // Length of the second string (the pattern to search for)
    
    // Loop through the 'first' string and check possible positions where 'second' might match 
    //this loop is for 1st
    for (int i = 0; i <= (m - n); i++)  {
        int j; // Variable to keep track of the comparison index in 'second'
        
        // Inner loop to compare each character of 'second' with the substring in 'first' starting at index 'i'
        //this loop is for 2nd
        for (j = 0; j < n; j++) {
            // If a character doesn't match, break out of the inner loop
            if (second[j] != first[i + j]) //i+j is to slide in first and check if it is matching.
            {
                break; // Exit the inner loop as there's no match at this position
            }
        }

        // If we have completed the inner loop, it means all characters of 'second' matched 'first' starting at position 'i'
        if (j == n) {
            // Print the starting index where the pattern 'second' is found in 'first'
            Console.Write(i + " "); 
        }
    }
  }

  public static void Main (string[] args) {
    string first = "ABCABCD"; // The first string in which we are searching for the pattern
    string second = "ABCD";   // The pattern (second string) we are searching for
    
    Console.WriteLine("All index numbers where pattern found:");
    patSearching(first, second); // Call the pattern searching function
  }
}

/*
All index numbers where pattern found: 
3 
*/