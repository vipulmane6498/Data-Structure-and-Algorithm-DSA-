/*
LongestEvenOddSubarray: level - Easy only logic no formula or pattern
Question: We want to find the longest sequence (subarray) where numbers appear alternatively
   as EVEN and ODD (like even → odd → even → odd...).

Approach:
1. We are given an array of numbers.
2. We want to find the longest sequence (subarray) where numbers appear alternatively
   as EVEN and ODD (like even → odd → even → odd...).
3. To do this:
   - Start from the 2nd element and check each pair of consecutive numbers.
   - If one is even and the other is odd, continue the count.
   - Otherwise, reset the count back to 1.
   - Keep track of the maximum length found so far.
*/
        
        //Efficient Solution: O(n) time complexity and O(1) space complexity
using System;

public class LongestEvenOddSubarray
{
    public static void Main(string[] args)
    {

        // Input array
        int[] arr = { 1, 3, 2, 4, 5, 8, 7, 3 };

        // result = longest alternating sequence length found so far
        int result = 0;

        // curr = length of current alternating sequence (start with 1 element)
        int curr = 1;

        // Loop through array starting from second element
        for (int i = 1; i < arr.Length; i++)
        {
            // Check if current and previous element are EVEN-ODD or ODD-EVEN
            if ((arr[i] % 2 == 0 && arr[i - 1] % 2 != 0) || 
                (arr[i] % 2 != 0 && arr[i - 1] % 2 == 0))
            {
                // If alternating → increase current count
                curr++;

                // Update result with maximum found so far
                result = Math.Max(result, curr);
            }
            else
            {
                // If not alternating → reset curr back to 1
                curr = 1;
            }
        }

        // Print final result
        System.Console.WriteLine("Longest Even Odd Subarray elements: " + result);

        /*
        🔎 Dry Run of Loop
        Array = {1, 3, 2, 4, 5, 8, 7, 3}
        Initial → result = 0, curr = 1

        | i | arr[i-1] | arr[i] | Alternating? | curr | result |
        |---|----------|--------|--------------|------|--------|
        | 1 | 1 (odd)  | 3 (odd) | ❌ No        | 1    | 0      |
        | 2 | 3 (odd)  | 2 (even) | ✅ Yes      | 2    | 2      |
        | 3 | 2 (even) | 4 (even) | ❌ No       | 1    | 2      |
        | 4 | 4 (even) | 5 (odd) | ✅ Yes      | 2    | 2      |
        | 5 | 5 (odd)  | 8 (even) | ✅ Yes      | 3    | 3      |
        | 6 | 8 (even) | 7 (odd) | ✅ Yes      | 4    | 4      |
        | 7 | 7 (odd)  | 3 (odd) | ❌ No       | 1    | 4      |

        ✅ Final Answer → Longest Even Odd Subarray elements: 4
        Subarray is {4, 5, 8, 7}
        */
    }
}
/*
OUTPUT:
Longest Even Odd Subarray elements: 4

*/