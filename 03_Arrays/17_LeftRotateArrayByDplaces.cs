//Left Rotate Array By D Places - level: Easy

// Approach: Reversal Algorithm for Left Rotation
// 1. Reverse the first 0 to d-1 elements.
// 2. Reverse the remaining d to n-1 elements.
// 3. Reverse the whole array 0 to n-1.
// This rotates the array to the left by 'd' places in O(n) time and O(1) extra space.

using System;

public class LeftRotateArrayByDplaces
{
    public static void Main(string[] args)
    {
        // Input array
        int[] arr = {1, 2, 3, 4, 5};
        int d = 2;                  // number of rotations
        int n = arr.Length;         // size of array

        Console.WriteLine("Before Rotation: ");
        Console.WriteLine(string.Join(" ", arr));

        // Perform left rotation
        LeftRotate(arr, n, d);
    }
    
    // Function to rotate array to the left by d places
    static void LeftRotate(int[] arr, int n, int d)
    {
        // Step 1: Reverse first 'd' elements
        Reverse(arr, 0, d - 1); //OUTPUT -> 2,1,3,4,5

        // Step 2: Reverse the rest (n-d) elements
        Reverse(arr, d, n - 1);//OUTPUT -> 2,1,5,4,3

        // Step 3: Reverse the whole array
        Reverse(arr, 0, n - 1);//OUTPUT ->3,4,5,1,2

        Console.WriteLine("After Rotation: ");
        Console.WriteLine(string.Join(" ", arr));  // Print rotated array
    }
    
    // Function to reverse part of the array from index 'low' to 'high'
    static void Reverse(int[] arr, int low, int high)
    {
        while (low < high)
        {
            int temp = arr[high];   // swap elements
            arr[high] = arr[low];
            arr[low] = temp;

            low++;
            high--;
        }

        
    }
}
/*
OUTPUT:

Before Rotation: 
1 2 3 4 5
After Rotation: 
3 4 5 1 2

*/