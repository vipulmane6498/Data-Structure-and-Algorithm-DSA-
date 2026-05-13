
    /*
    Maximum Product Subarray: Medium
    
    Problem:
    Given an array of integers, find the contiguous subarray within an array (containing at
    least one number) which has the largest product.
    Example:
    Input: [6, -3, -10, 0, 2]
    Output: 180
    Explanation: The subarray [6, -3, -10] has the maximum product 180. 

    ---------------------------------------------------------
    Approach:
    ---------------------------------------------------------
    We use Dynamic Programming approach to solve this problem.

    At every index, we maintain:

    1. maxEnd
       -> Maximum product subarray ending at current index.

    2. minEnd
       -> Minimum product subarray ending at current index.

    Why minEnd is needed?
    Because multiplying two negative numbers can produce
    a large positive product.

    If current element is negative:
    - Swap maxEnd and minEnd
    because:
    max * negative = minimum
    min * negative = maximum

    Then:
    - Update maxEnd using maximum value between:
        a) Current element itself
        b) Current element * previous maxEnd

    - Update minEnd using minimum value between:
        a) Current element itself
        b) Current element * previous minEnd

    - Update overall product.

    ---------------------------------------------------------
    Dry Run:
    ---------------------------------------------------------

    Input:
    arr[] = {6, -3, -10, 0, 2}

    Initial:
    maxEnd = 6
    minEnd = 6
    product = 6

    ---------------------------------------------------------
    i = 1, arr[i] = -3

    Negative element found
    Swap maxEnd and minEnd

    maxEnd = max( -3, 6 * -3 )
            = max(-3, -18)
            = -3

    minEnd = min( -3, 6 * -3 )
            = min(-3, -18)
            = -18

    product = max(6, -3)
            = 6

    ---------------------------------------------------------
    i = 2, arr[i] = -10

    Negative element found
Swap maxEnd and minEnd

Before Swap:
maxEnd = -3
minEnd = -18

After Swap:
maxEnd = -18
minEnd = -3

    maxEnd = max( -10, -18 * -10 )
            = max(-10, 180)
            = 180

    minEnd = min( -10, -3 * -10 )
            = min(-10, 30)
            = -10

    product = max(6, 180)
            = 180

    ---------------------------------------------------------
    i = 3, arr[i] = 0

    maxEnd = max(0, 180 * 0)
            = 0

    minEnd = min(0, -10 * 0)
            = 0

    product = max(180, 0)
            = 180

    ---------------------------------------------------------
    i = 4, arr[i] = 2

    maxEnd = max(2, 0 * 2)
            = 2

    minEnd = min(2, 0 * 2)
            = 0

    product = max(180, 2)
            = 180

    ---------------------------------------------------------
    Final Output:
    180
    ---------------------------------------------------------

    Time Complexity:
    O(N)
    -> We traverse the array only once.

    Space Complexity:
    O(1)
    -> Constant extra space is used.
    ---------------------------------------------------------
    */

using System;

class Solution {
    public int maxProduct(int[] arr) {

        // Maximum product ending at current position
        int maxEnd = arr[0];

        // Minimum product ending at current position
        int minEnd = arr[0];

        // Stores final maximum product
        int product = arr[0];

        // Traverse array from index 1
        for (int i = 1; i < arr.Length; i++) {

            // If current element is negative,
            // swap maxEnd and minEnd
            if (arr[i] < 0) {

                int temp = maxEnd;
                maxEnd = minEnd;
                minEnd = temp;
            }

            // Calculate maximum product ending here
            maxEnd = Math.Max(arr[i], maxEnd * arr[i]);

            // Calculate minimum product ending here
            minEnd = Math.Min(arr[i], minEnd * arr[i]);

            // Update overall maximum product
            product = Math.Max(product, maxEnd);
        }

        // Return final answer
        return product;
    }

    // Main Method
    public static void Main(string[] args) {

        int[] arr = {6, -3, -10, 0, 2};

        Solution obj = new Solution();

        int result = obj.maxProduct(arr);

        Console.WriteLine("Maximum Product Subarray: " + result);
    }
}