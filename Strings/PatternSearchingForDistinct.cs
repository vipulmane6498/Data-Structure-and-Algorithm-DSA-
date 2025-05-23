//Pattern searching for distinct: It means that we are searching for a pattern in a string and if we find it only once then we will return true otherwise false.


//Approach:
//Once pattern found will increase count and will store the index of the first match.
//If count is 1 then will return the index of the first match otherwise will return false.

// 1. Inputs:
//    1.1 first: Main string
//    1.2 second: Pattern to search
// 2. Track:
//    2.1 count: Number of times the pattern appears
//    2.2 foundIndex: Index of the first match
// 3. Loop through first:
//    3.1 Compare substring with second at each position
//    3.2 If matched, increment count and store index
// 4. After loop:
//    4.1 If count == 1, print the index
//    4.2 Else, print it's not distinct (found multiple or zero times)

using System;

class MainClass {
    // Function to perform pattern searching
    public static void patSearching(string first, string second)
    {
        int m = first.Length; // Length of the first string
        int n = second.Length; // Length of the second string (the pattern to search for)

        int count = 0; //To check how many times pattern found
        int foundIndex = -1; // To get the 1st index of pattern match.
                             // Loop through the 'first' string and check possible positions where 'second' might match 
                             //this loop is for 1st
        for (int i = 0; i <= (m - n); i++)
        {
            int j; // Variable to keep track of the comparison index in 'second'

            // Inner loop to compare each character of 'second' with the substring in 'first' starting at index 'i'
            //this loop is for 2nd
            for (j = 0; j < n; j++)
            {
                // If a character doesn't match, break out of the inner loop
                if (second[j] != first[i + j]) //i+j is to slide in first and check if it is matching.
                {
                    break; // Exit the inner loop as there's no match at this position
                }
            }
            //***********************************
            // If we have completed the inner loop, it means all characters of 'second' matched 'first' starting at position 'i'
            if (j == n)
            {
                // Print the starting index where the pattern 'second' is found in 'first'
                count++; //Incease count if pattern match 
                foundIndex = i; //1st index of pattern match
            }
        }
        // Check if the pattern was found exactly once
        if (count == 1)
        {
            Console.WriteLine("Pattern found at index: " + foundIndex);
        }
        else
        {
            Console.WriteLine("Pattern is not distinct (found " + count + " times)");
        }
        //**************************************
  }

  public static void Main (string[] args) {
    string first = "ABCABCDEABCD"; // The first string in which we are searching for the pattern
    string second = "ABCD";   // The pattern (second string) we are searching for
    
    Console.WriteLine("All index numbers where pattern found:");
    patSearching(first, second); // Call the pattern searching function
  }
}

/*
All index numbers where pattern found: 
3 
*/

