// maximum Consecutive 1's in an Array: level easy - only logic


//Approach:
// We are given an array containing 0's and 1's.
// We want to find the maximum number of consecutive (back-to-back) 1's.
// Example: In [0,1,1,1,0,1,1,0] -> the longest sequence of 1's is "1,1,1" -> length = 3.
// To solve this efficiently:
// 1. We go through the array only once (single loop).
// 2. We keep a counter 'count' that increases when we see 1, and becomes 0 when we see 0.
// 3. Whenever we increase 'count', we check if it is bigger than 'x' (maximum so far).
// 4. At the end, 'x' will have the largest sequence of 1's.
//Time Complexity: O(n) - We only loop through the array once.


//Efficient Solution: O(n) time complexity and O(1) space complexity
using System;

public class MaximumConsecutive1S
{
    public static void Main(string[] args)
    {
        // Array containing 0's and 1's
        int[] arr = {0,1,1,1,0,1,1,0};
        
        // Length of the array
        int n = arr.Length;

        // 'x' will store the maximum consecutive 1's found so far
        int x = 0;

        // 'count' will store the current sequence of consecutive 1's
        int count = 0;

        // Loop through the array once
        for (int i = 0; i < n; i++)
        {
            if (arr[i] == 0)
            {
                // If we find 0, reset count (break in sequence)
                count = 0;
            }
            else
            {
                // If we find 1, increase count
                count++;

                // Update maximum if this sequence is longer
                if (count > x)
                {
                    x = count;
                }
            }
        }

        // Print the final maximum consecutive 1's
        Console.Write(x);
    }
}
