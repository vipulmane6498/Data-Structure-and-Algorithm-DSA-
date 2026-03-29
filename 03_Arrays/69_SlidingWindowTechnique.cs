
/*
Sliding Window Technique -  Medium
    solution in brief: add the first k elements(index 0 to k-1) and then keep adding next element and removing previous element to get the sum of next window. Keep updating the maximum sum.

APPROACH (Sliding Window Technique):
Steps:
1. We are given an array and a number k (window size).
2. We need to find the maximum sum of any k consecutive elements.
3. First, calculate sum of first k elements (first window).
4. Then move the window one step forward:
   - Add next element
   - Remove previous element
5. Keep updating the maximum sum.

This avoids recalculating sum again and again (fast method).

Time Complexity: O(n)
Space Complexity: O(1)
*/

using System;
public class SlidingWindowTechnique
{
    public static void Main(string[] args)
    {
        // Step 1: Create an array
        int[] arr = {1, 8, 30, -5, 20, 7};
        
        // Step 2: Window size
        int k = 3;

        // Step 3: Calculate sum of first 'k' elements
        int currSum = 0;
        for (int i = 0; i < k; i++)
        {
            currSum = currSum + arr[i];  // Adding first window elements
        }

        // Step 4: Assume first window sum is maximum
        int maxSum = currSum;

        // Step 5: Slide the window
        for (int i = k; i < arr.Length; i++)
        {
            // Add next element and remove previous element
            currSum = currSum + arr[i] - arr[i - k];

            /*
            Windows:
             {1, 8, 30, -5, 20, 7}
            1 + 8 + 30 = 39
            8 + 30 + (-5) = 33
            30 + (-5) + 20 = 45  <-- Maximum
            -5 + 20 + 7 = 22
            */

            // Update maxSum if current sum is greater
            maxSum = Math.Max(maxSum, currSum); //45
        }

        // Step 6: Print result
        Console.WriteLine("Max Sum is: " + maxSum);
    }
}

/*
OUTPUT:
Max Sum is: 45
*/
