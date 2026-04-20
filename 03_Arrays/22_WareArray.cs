        /*

        Wave Array: Easy

        Problem statement: Given an array of integers, rearrange the elements in a wave-like pattern such that:
        arr[0] >= arr[1] <= arr[2] >= arr[3] <= arr[4] ...
        E.g. Input: [1, 2, 3, 4, 5] → Output: [2, 1, 4, 3, 5]

        ================== APPROACH ==================
        1. Traverse the array starting from index 1.
        2. Swap elements at index i and i-1.
        3. Increment i by 2 to skip next element.
        4. This creates a wave pattern:
           arr[0] >= arr[1] <= arr[2] >= arr[3] ...

        Example:
        Input  : [1, 2, 3, 4, 5]
        Step 1 : swap(1,2) → [2, 1, 3, 4, 5]
        Step 2 : swap(3,4) → [2, 1, 4, 3, 5]
        Output : [2, 1, 4, 3, 5]
        =============================================

        Time Complexity: O(n)
        Space Complexity: O(1) - in-place rearrangement
  
        */


using System;

public class WaveArray
{
    public static void Main(string[] args)
    {
        // Input array
        int[] arr = {1, 2, 3, 4, 5};


        // Traverse array with step of 2
        for (int i = 1; i < arr.Length; i = i + 2)
        {
            // Swap current element with previous element
            int temp = arr[i];
            arr[i] = arr[i - 1];
            arr[i - 1] = temp;
        }

        // Print the wave array
        for (int j = 0; j < arr.Length; j++)
        {
            Console.Write(arr[j] + " ");
        }
    }
}
/*
OUTPUT:
2 1 4 3 5 
*/