
    /*
    Maximum Circular Subarray Sum

    Examples:

        Input: arr[] = [8, -8, 9, -9, 10, -11, 12]
        Output: 22
        Explanation: Starting from the last element of the array, i.e, 12, and moving in a circular fashion, we have max subarray as 12, 8, -8, 9, -9, 10, which gives maximum sum as 22.

        Input: arr[] = [10, -3, -4, 7, 6, 5, -4, -1]
        Output: 23
        Explanation: Maximum sum of the circular subarray is 23. The subarray is [7, 6, 5, -4, -1, 10].

        Input: arr[] = [5, -2, 3, 4]
        Output: 12
        Explanation: The circular subarray [3, 4, 5] gives the maximum sum of 12.
    ==================================================
    🚀 APPROACH (Maximum Circular Subarray Sum) - Medium
    ==================================================

    In circular array, maximum subarray sum can be found in 2 ways:

    1️⃣ Normal Maximum Subarray Sum
       → Using Kadane’s Algorithm

    2️⃣ Circular Maximum Subarray Sum
       → Total Array Sum - Minimum Subarray Sum

       Why?
       Because removing the minimum subarray leaves
       the maximum circular part.

    Final Answer:
    max(normalMaxSum, circularMaxSum)

    --------------------------------------------------
    ⚠ Edge Case:
    If all elements are negative,
    then circular sum becomes 0 which is incorrect.

    So if normalMaxSum < 0,
    directly return normalMaxSum.

    ==================================================
    ⏱ TIME COMPLEXITY:
    O(n) → Single traversal

    🧠 SPACE COMPLEXITY:
    O(1)

    ==================================================
    📌 DRY RUN:
    Input: [5, -2, 3, 4]

    ➤ Normal Kadane:
    Maximum Subarray Sum = 10

    ➤ Total Sum:
    5 + (-2) + 3 + 4 = 10

    ➤ Minimum Subarray Sum:
    -2

    ➤ Circular Sum:
    10 - (-2) = 12

    Final Answer:
    max(10, 12) = 12

    ==================================================
    ✅ OUTPUT:
    12
    ==================================================
    */

using System;

class CircularSubarraySum {
    public int circularSubarraySum(int[] arr) {

        int totalSum = 0;

        // For maximum subarray sum
        int currMax = arr[0];
        int maxSum = arr[0];

        // For minimum subarray sum
        int currMin = arr[0];
        int minSum = arr[0];

        totalSum = arr[0];

        for(int i = 1; i < arr.Length; i++) {

            totalSum += arr[i];

            // Kadane for maximum sum
            currMax = Math.Max(arr[i], currMax + arr[i]);
            maxSum = Math.Max(maxSum, currMax);

            // Kadane for minimum sum
            currMin = Math.Min(arr[i], currMin + arr[i]);
            minSum = Math.Min(minSum, currMin);
        }

        // If all elements are negative
        if(maxSum < 0) {
            return maxSum;
        }

        // Circular maximum sum
        int circularSum = totalSum - minSum;

        // Return maximum of normal and circular
        return Math.Max(maxSum, circularSum);
    }

    // Main Method
    public static void Main(string[] args) {

        int[] arr = { 5, -2, 3, 4 };

        CircularSubarraySum obj = new CircularSubarraySum();

        int result = obj.circularSubarraySum(arr);

        Console.WriteLine("Maximum Circular Subarray Sum: " + result);
    }
}
/*
OUTPUT:
Maximum Circular Subarray Sum: 12
*/