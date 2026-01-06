/* Sort Array by Increasing Frequency - Medium
Given an array of integers nums, sort the array in increasing order based on the frequency of the values. If multiple values have the same frequency, sort them in decreasing order.

APPROACH:

1. Take the input array containing integers.
   Example: nums = {1, 1, 2, 2, 2, 3}

2. Use a Dictionary<int, int> to store the frequency of each element.
   - Traverse the array using a simple for loop.
   - If the element is not present in the dictionary, add it with frequency 1.
   - If it already exists, increment its frequency.

3. Print the frequency of each element by iterating over the dictionary keys.

4. Sort the original array using Bubble Sort based on custom conditions:
   a) Compare the frequency of adjacent elements using the dictionary.
   b) If the frequency of the current element is greater than the next element,
      swap them (lower frequency should come first).
   c) If both elements have the same frequency, place the larger value first.

5. After sorting is complete, print the sorted array using a simple for loop.

This approach ensures the array is sorted primarily by frequency
and secondarily by element value.
*/


using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // ===============================
        // DRY RUN – STEP 0: Input
        // nums = {1, 1, 2, 2, 2, 3}
        // ===============================
        int[] nums = { 1, 1, 2, 2, 2, 3 };

        // ===============================
        // STEP 1: Count frequencies
        // ===============================
        Dictionary<int, int> freq = new Dictionary<int, int>();

        // Loop through nums array
        for (int i = 0; i < nums.Length; i++)
        {
            // DRY RUN:
            // i=0 → nums[0]=1 → not in dictionary → freq[1]=1
            // i=1 → nums[1]=1 → already present → freq[1]=2
            // i=2 → nums[2]=2 → not present → freq[2]=1
            // i=3 → nums[3]=2 → freq[2]=2
            // i=4 → nums[4]=2 → freq[2]=3
            // i=5 → nums[5]=3 → freq[3]=1

            if (!freq.ContainsKey(nums[i]))
            {
                freq[nums[i]] = 1;
            }
            else
            {
                freq[nums[i]]++;
            }
        }

        // Final Dictionary after loop:
        // freq = { 1 -> 2, 2 -> 3, 3 -> 1 }

        // ===============================
        // Print frequency map
        // ===============================
        Console.WriteLine("Frequency of elements:");
        List<int> keys = new List<int>(freq.Keys);

        for (int i = 0; i < keys.Count; i++)
        {
            int key = keys[i];
            Console.WriteLine(key + " -> " + freq[key]);
        }

        // Output:
        // 1 -> 2
        // 2 -> 3
        // 3 -> 1

        // ===============================
        // STEP 2: Bubble Sort based on:
        // 1) Lower frequency first
        // 2) If frequency same, higher value first
        // ===============================

        for (int i = 0; i < nums.Length - 1; i++)
        {
            for (int j = 0; j < nums.Length - i - 1; j++)
            {
                int freqA = freq[nums[j]];
                int freqB = freq[nums[j + 1]];

                // DRY RUN (first few comparisons):
                // nums = {1, 1, 2, 2, 2, 3}

                // Compare nums[0]=1 (freq=2) and nums[1]=1 (freq=2)
                // Same freq & same value → no swap

                // Compare nums[1]=1 (freq=2) and nums[2]=2 (freq=3)
                // freqA < freqB → no swap

                // Compare nums[4]=2 (freq=3) and nums[5]=3 (freq=1)
                // freqA > freqB → swap → 3 comes before 2

                // Swap condition:
                if (freqA > freqB || (freqA == freqB && nums[j] < nums[j + 1]))
                {
                    int temp = nums[j];
                    nums[j] = nums[j + 1];
                    nums[j + 1] = temp;
                }
            }
        }

        // Final sorted array after complete dry run:
        // nums = {3, 1, 1, 2, 2, 2}

        // ===============================
        // STEP 3: Print sorted array
        // ===============================
        Console.WriteLine("\nSorted array:");
        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i]);
            if (i < nums.Length - 1)
                Console.Write(", ");
        }
        Console.WriteLine();

        // Output:
        // Sorted array:
        // 3, 1, 1, 2, 2, 2
    }
}


/*
OUTPUT:
Frequency of elements:
1 -> 2
2 -> 3
3 -> 1

Sorted array:
3, 1, 1, 2, 2, 2
*/