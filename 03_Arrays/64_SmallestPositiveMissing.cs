/*
 * ============================================================
 *  APPROACH: Find the Smallest Missing Positive Number - Medium
 * ============================================================
 *
 * PROBLEM:
 *   Given an integer array, find the smallest missing positive number.
 *
 * STEPS:
 *   1. If array has 0 or 1 element, return 1 (smallest possible missing).
 *
 *   2. Find MIN and MAX of the array by iterating once.
 *
 *   3. Store all array elements in a HashSet for O(1) lookup.
 *
 *   4. Sort the array and check adjacent elements:
 *      - If difference between two adjacent numbers > 2,
 *        it means MORE than 1 number is missing in between.
 *      - In that case, return 1 as the smallest missing positive.
 *        e.g. {1, 2, 5} → gap between 2 and 5 is 3 → return 1
 *
 *   5. Iterate from MIN to MAX:
 *      - Skip non-positive numbers (i <= 0).
 *      - Return the first number NOT found in the HashSet.
 *        e.g. {1, 2, 4} → 3 is missing → return 3
 *
 *   6. If no missing number found in range, return max+1.
 *      e.g. {1, 2, 3} → return 4
 *
 * TIME COMPLEXITY  : O(N log N) — due to Array.Sort()
 * SPACE COMPLEXITY : O(N)       — due to HashSet
 *
 * ============================================================
 *  TEST CASES:
 * ============================================================
 *
 *   Input          | Expected Output | Reason
 *   ---------------|-----------------|-------------------------------
 *   {1, 2, 4, 5, 6}|       3         | 3 is missing in between
 *   {2, 3, 4, 5}   |       1         |  No missing, return max+1
 *   {1}            |       1         | Single element, return 1
 *   {1, 2, 3, 4, 5}|       6         | No missing, return max+1
 *   {8, 11}        |       1         | Gap > 2, return 1
 *   {1, 2, 5}      |       1         | Gap > 2 (2 to 5), return 1
 *   {1, -2, 5}     |       1         | Gap > 2 (1 to 5), return 1, if negative numbers are present we will skip them in step 5 and return 1 as smallest missing positive
 * ============================================================
 */

using System;
using System.Collections.Generic;

class Solution {
    public int missingNumber(int[] arr) {

        // Step 1: If array has 0 or 1 element, smallest missing positive is 1
        if (arr.Length <= 1) {
            return 1;
        }

        // Step 2: Find MIN and MAX values in the array
        int min = arr[0];
        int max = arr[0];

        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] > max) {
                max = arr[i];   // Update max if larger element found
            }
            if (arr[i] < min) {
                min = arr[i];   // Update min if smaller element found
            }
        }

        // Step 3: Store all elements in HashSet for O(1) lookup will remove duplicates and allow us to check presence of numbers efficiently
        HashSet<int> set = new HashSet<int>(arr);

        // Step 4: Sort array to check adjacent element differences
        Array.Sort(arr);

        for (int i = 0; i < arr.Length - 1; i++) {
            // If gap between two adjacent numbers is more than 2, e.g. 1,2,3,6 -> gap is 6-3=3 more than 2 → return 1 as smallest missing positive
            // multiple numbers are missing → return 1
            if (arr[i + 1] - arr[i] > 2) {
                return 1;
            }
        }

        // Step 5: Iterate from min to max and find first missing positive
        for (int i = min; i <= max; i++) {

            // Skip non-positive numbers
            if (i <= 0) {
                continue; //jump to next iteration if i is 0 or negative, we are only interested in positive numbers
            }

            // Return the first number not present in the HashSet
            if (!set.Contains(i)) {
                return i;
            }
        }

        // Step 6: No missing number in range, return next number after max
        return max + 1;
    }

    static void Main(string[] args) {
        Solution sol = new Solution();

        // Test Case 1: {1, 2, 4, 5, 6} → 3 is missing in between
        int[] arr1 = { 1, 2, 4, 5, 6 };
        Console.WriteLine("Missing number: " + sol.missingNumber(arr1)); // Output: 3

        // Test Case 2: {2, 3, 4, 5} → 1 is missing at the beginning
        int[] arr2 = { 2, 3, 4, 5 };
        Console.WriteLine("Missing number: " + sol.missingNumber(arr2)); // Output: 1

        // Test Case 3: {1} → Single element, return 1
        int[] arr3 = { 1 };
        Console.WriteLine("Missing number: " + sol.missingNumber(arr3)); // Output: 1

        // Test Case 4: {1, 2, 3, 4, 5} → No missing number, return max+1
        int[] arr4 = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Missing number: " + sol.missingNumber(arr4)); // Output: 6

        // Test Case 5: {8, 11} → Gap between 8 and 11 is 3 (> 2), return 1
        int[] arr5 = { 8, 11 };
        Console.WriteLine("Missing number: " + sol.missingNumber(arr5)); // Output: 1

        // Test Case 6: {1, 2, 5} → Gap between 2 and 5 is 3 (> 2), return 1
        int[] arr6 = { 1, 2, 5 };
        Console.WriteLine("Missing number: " + sol.missingNumber(arr6)); // Output: 1
    }
}
/*
OUTPUT:
Missing number: 3
Missing number: 6
Missing number: 1
Missing number: 6
Missing number: 1
Missing number: 1

*/