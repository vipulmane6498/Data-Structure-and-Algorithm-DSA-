
    /*
    Rearrange an array with O(1) extra space -  Medium(but solution is easy)

        e.g. arr = [4, 0, 2, 1, 3]
        Output: [3, 4, 2, 0, 1]
    Brief Solution:
    1. We create a new array (newArr) to store the rearranged values
    2. We fill newArr using the condition: newArr[i] = arr[arr[i]]
    3. Finally, we copy the values from newArr back to the original array.

    ---------------------------------------------------------
    APPROACH:   
    ---------------------------------------------------------
    - We are given an array where each element represents an index.
    - The goal is to rearrange the array such that:
          arr[i] = arr[arr[i]]

    - Simple understanding with example:
      Suppose:
          arr = [4, 0, 2, 1, 3]
          OUTPUT:  [3, 4, 2, 0, 1]

      Now look at index 0:
          arr[0] = 4  → go to index 4
          arr[4] = 3  → this becomes new value at index 0
          so it works like: newArr[0] = arr[arr[0]] = arr[4] = 3

      So:
          newArr[0] = 3

      Similarly:
          arr[1] = 0 → arr[0] = 4 → newArr[1] = 4
          arr[2] = 2 → arr[2] = 2 → newArr[2] = 2
          arr[3] = 1 → arr[1] = 0 → newArr[3] = 0
          arr[4] = 3 → arr[3] = 1 → newArr[4] = 1

      Final result:
          [3, 4, 2, 0, 1]

    - Steps:
      1. Create a new array (newArr).
      2. Store values using: newArr[i] = arr[arr[i]]
      3. Copy newArr back to original array.

    ---------------------------------------------------------
    TIME COMPLEXITY:
    ---------------------------------------------------------
    O(n) → We traverse the array twice.

    ---------------------------------------------------------
    SPACE COMPLEXITY:
    ---------------------------------------------------------
    O(n) → Extra array (newArr) is used.
    ---------------------------------------------------------
    */
using System;

class Solution {

    public void arrange(long[] arr) {
        
        // Create a new array to store rearranged values
        long[] newArr = new long[arr.Length];
        
        // Fill newArr using given condition
        for (int i = 0; i < arr.Length; i++) {
            newArr[i] = arr[arr[i]];   // core logic
        }
        
        // Copy values back to original array
        for (int i = 0; i < arr.Length; i++) {
            arr[i] = newArr[i];
        }
    }

    // Main method to test the solution
    public static void Main(string[] args) {
        
        // Example input
        long[] arr = {4, 0, 2, 1, 3};
        
        Solution obj = new Solution();
        
        obj.arrange(arr);
        
        Console.WriteLine("Rearranged array:");
        
        foreach (long num in arr) {
            Console.Write(num + " ");
        }
    }
}
/*
OUTPUT:
Rearranged array:
3 4 2 0 1
*/