// =============================================
// ✅ PROBLEM: Next Permutation - Medium
// Given an array of integers, rearrange the numbers to get the lexicographically next greater permutation of the given array. If such arrangement is not possible, rearrange it as the lowest possible order (i.e., sorted in ascending order).
//    e.g. Input: [1, 3, 4, 5, 2] → Output: [1, 3, 5, 2, 4]
//         Input: [5, 4, 3, 2, 1] → Output: [1, 2, 3, 4, 5]
// =============================================

// 🔥 APPROACH (Step-by-Step):
// 1. Traverse from right → left, find first index (gola_index) where:
//       arr[i-1] < arr[i]
//    → once you find break the loop. This is the "break point"
//      e.g. For [1, 3, 4, 5, 2], gola_index = 2 (value = 4) because 4 < 5
//
// 2. If such index exists:
//    - Traverse again from right → find just greater element than arr[gola_index]
//    - Swap both elements
//      e.g. Just greater than 4 is 5 → swap → [1, 3, 5, 4, 2]
//
// 3. Reverse the elements from (gola_index + 1) to end
//
// 4. If no gola_index found (array in descending order),
//    reverse entire array

// =============================================
// 🔍 DRY RUN EXAMPLE:
// Input: [1, 3, 4, 5, 2]
//
// Step 1: Find gola_index
// Compare from right:
// 5 > 2 ❌
// 4 < 5 ✅ → gola_index = 2 (value = 4)
//
// Step 2: Find just greater element than 4 (from right)
// → 5 is just greater → swap
// After swap: [1, 3, 5, 4, 2]
//
// Step 3: Reverse right side of gola_index (index 3 → end)
// Before reverse: [4, 2]
// After reverse:  [2, 4]
//
// Final Output: [1, 3, 5, 2, 4]
// =============================================

// ⏱ Time Complexity: O(n)
// 📦 Space Complexity: O(1)

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] arr = {1, 3, 4, 5, 2};
        int n = arr.Length;

        int gola_index = -1; // stores breakpoint index

        // 🔹 Step 1: Find gola_index (first decreasing element from right)
        for (int i = n - 1; i > 0; i--)
        {
            // check if current element is greater than previous
            if (arr[i - 1] < arr[i])
            {
                gola_index = i - 1;
                break;
            }
        }

        // 🔹 Step 2: Find element just greater than arr[gola_index] and swap
        if (gola_index != -1)
        {
            int swap_index = gola_index;

            // traverse from right to find just greater element
            for (int i = n - 1; i > gola_index; i--)
            {
                if (arr[i] > arr[gola_index])
                {
                    swap_index = i;
                    break;
                }
            }

            // swap gola element with found element
            int temp = arr[gola_index];
            arr[gola_index] = arr[swap_index];
            arr[swap_index] = temp;
        }

        // 🔹 Step 3: Reverse the right side of gola_index
        int low = gola_index + 1; // start just after gola_index
        int high = n - 1;
        while (low < high)
        {
            int temp = arr[low];
            arr[low] = arr[high];
            arr[high] = temp;

            low++;
            high--;
        }

        // 🔹 Step 4: Print result
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
/*
OUTPUT:
1 3 5 2 4
*/  