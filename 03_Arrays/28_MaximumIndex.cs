// ------------------------------------------------------------
// 🧠 APPROACH: Two-Pointer Method with Preprocessing (LMin & RMax Arrays)
// ------------------------------------------------------------
//
// 🎯 Problem:
// Given an array, find the maximum index difference (j - i)
// such that arr[j] >= arr[i] and j > i.
//
// ------------------------------------------------------------
// ⚙️ Steps:
//
// 1️⃣ Build LMin[] array
//     → LMin[i] stores the minimum element from index 0 to i.
//     → This helps to quickly know the smallest value seen so far
//        when moving from left to right.
//
// 2️⃣ Build RMax[] array
//     → RMax[j] stores the maximum element from index j to (n-1).
//     → This helps to know the largest value seen so far
//        when moving from right to left.
//
// 3️⃣ Use Two Pointers (iPtr and jPtr)
//     → Start with iPtr = 0, jPtr = 0
//     → If LMin[iPtr] <= RMax[jPtr], update maxDiff = max(maxDiff, jPtr - iPtr)
//        and move jPtr forward to find a larger distance.
//     → Else, move iPtr forward to find a smaller LMin value.
//
// ------------------------------------------------------------
// 💡 Example:
//
// arr = [34, 8, 10, 3, 2, 80, 30, 33, 1]
//
// Step 1: LMin = [34, 8, 8, 3, 2, 2, 2, 2, 1]
// Step 2: RMax = [80, 80, 80, 80, 80, 80, 33, 33, 1]
//
// Step 3: Using two pointers:
//          Compare LMin[iPtr] and RMax[jPtr],
//          move jPtr if condition true, else iPtr.
//
// Final Result → Maximum index difference = 6
// (for i = 1, j = 7 → arr[i] = 8, arr[j] = 33)
//
// ------------------------------------------------------------
// ⏱️ Time Complexity: O(n)
// 💾 Space Complexity: O(n)
// ------------------------------------------------------------

using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<int> arr = new List<int> { 34, 8, 10, 3, 2, 80, 30, 33, 1 };
        int n = arr.Count;
        int[] LMin = new int[n];
        int[] RMax = new int[n];

        // Step 1: Build LMin[]
        LMin[0] = arr[0];
        for (int i = 1; i < n; i++)
        {
            LMin[i] = Math.Min(arr[i], LMin[i - 1]);
        }
        // After loop:
        // LMin = [34, 8, 8, 3, 2, 2, 2, 2, 1]

        // Step 2: Build RMax[]
        RMax[n - 1] = arr[n - 1];
        for (int i = n - 2; i >= 0; i--)
        {
            RMax[i] = Math.Max(arr[i], RMax[i + 1]);
        }
        // After loop:
        // RMax = [80, 80, 80, 80, 80, 80, 33, 33, 1]

        // Step 3: Find maximum index difference
        int iPtr = 0, jPtr = 0, maxDiff = 0;

        while (iPtr < n && jPtr < n)
        {
            if (LMin[iPtr] <= RMax[jPtr])
            {
                maxDiff = Math.Max(maxDiff, jPtr - iPtr);
                jPtr++;
            }
            else
            {
                iPtr++;
            }

            // ---- DRY RUN ----
            // Step-by-step comparison between LMin[iPtr] and RMax[jPtr]
            // LMin = [34, 8, 8, 3, 2, 2, 2, 2, 1]
            // RMax = [80, 80, 80, 80, 80, 80, 33, 33, 1]
            //
            // iPtr | jPtr | LMin[iPtr] | RMax[jPtr] | Condition (<=) | Action         | maxDiff
            // -----------------------------------------------------------------------------------
            //  0   |  0   |    34      |     80     |  True          | jPtr++ (to 1)  | 0
            //  0   |  1   |    34      |     80     |  True          | jPtr++ (to 2)  | 1
            //  0   |  2   |    34      |     80     |  True          | jPtr++ (to 3)  | 2
            //  0   |  3   |    34      |     80     |  True          | jPtr++ (to 4)  | 3
            //  0   |  4   |    34      |     80     |  True          | jPtr++ (to 5)  | 4
            //  0   |  5   |    34      |     80     |  True          | jPtr++ (to 6)  | 5
            //  0   |  6   |    34      |     33     |  False         | iPtr++ (to 1)  | 5
            //  1   |  6   |    8       |     33     |  True          | jPtr++ (to 7)  | 5
            //  1   |  7   |    8       |     33     |  True          | jPtr++ (to 8)  | 6
            //  1   |  8   |    8       |      1     |  False         | iPtr++ (to 2)  | 6
            //  ...
            // Final maxDiff = 6
        }

        Console.WriteLine("Maximum index difference: " + maxDiff);
    }
}

/*
OUTPUT:
Maximum index difference: 6
*/
