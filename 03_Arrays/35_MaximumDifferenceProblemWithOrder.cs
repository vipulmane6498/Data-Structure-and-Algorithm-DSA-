

/*
Maximum Difference Problem with Order:


*/

// Approach:
// We are given an array of numbers, and we want to find the maximum difference
// (arr[j] - arr[i]) such that j > i.  
// In simple words: We want to buy at a lower number first and then sell at a higher number later,
// and we want to know the maximum possible profit (difference).
// For this, we keep track of the minimum value we have seen so far (minVal)
// and calculate the difference with the current number. We keep updating the result if we find a bigger difference.

using System;

public class MaximumDifferenceProblemWithOrder
{
    public static void Main(string[] args)
    {
        // Our input array
        int[] arr = {2, 3, 10, 6, 4, 8, 1};

        // 1. Initialize result as the difference between 2nd element and 1st element
        int res = arr[1] - arr[0];

        // 2. Initialize the minimum value as the first element
        int minVal = arr[0];

        // 3. Loop through array starting from index 1
        for (int j = 1; j < arr.Length; j++)
        {
            // Calculate difference of current element with minimum seen so far
            // and update result if it is larger than previous result
            res = Math.Max(res, arr[j] - minVal);

            // Update minVal if the current element is smaller
            minVal = Math.Min(minVal, arr[j]);
        }

        /*
        Dry Run (Step by Step for Input {2, 3, 10, 6, 4, 8, 1})
            Initial values:
            res = 3 - 2 = 1

            minVal = 2

            Loop starts:
            j = 1 → arr[1] = 3
            res = max(1, 3 - 2) = max(1, 1) = 1
            minVal = min(2, 3) = 2
            j = 2 → arr[2] = 10
            res = max(1, 10 - 2) = max(1, 8) = 8
            minVal = min(2, 10) = 2
            j = 3 → arr[3] = 6
            res = max(8, 6 - 2) = max(8, 4) = 8
            minVal = min(2, 6) = 2
            j = 4 → arr[4] = 4
            res = max(8, 4 - 2) = max(8, 2) = 8
            minVal = min(2, 4) = 2
            j = 5 → arr[5] = 8
            res = max(8, 8 - 2) = max(8, 6) = 8
            minVal = min(2, 8) = 2
            j = 6 → arr[6] = 1
            res = max(8, 1 - 2) = max(8, -1) = 8
            minVal = min(2, 1) = 1
                */
                
        // 4. Print the maximum difference
        System.Console.WriteLine("Maximum Difference Problem with Order is: " + res);
    }
}
/*
OUTPUT:
Maximum Difference Problem with Order is: 8

*/