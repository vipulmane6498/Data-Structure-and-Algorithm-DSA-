
// Move all zeros to the end of an array - easy
// there are 2 approaches to solve this problem.
// 1. Easy Approach
// 2. Efficient Approach

//A. Easy Approach:
// 1. Outer Loop (i):
// Traverse each element from start to end.

// 2. If current element arr[i] is 0:
// Search ahead (j = i + 1) for the next non-zero element.

// 3. Inner Loop (j):
// Find the first arr[j] != 0.
// When found, swap arr[i] and arr[j].
// Use break after the swap so we don’t keep looping unnecessarily.

// 4. Result:
// All non-zero values are shifted toward the front.
//Zeros get pushed toward the end as they are swapped out.


using System;

public class LeftRotateArrayByOne
{
    public static void Main(String[] args)
    {
        int[] arr = { 10, 8, 0, 0, 5, 6 };
        int n = arr.Length;

        MoveToEnd(arr, n);
    }

    static void MoveToEnd(int[] arr, int n)
    {
        // Traverse the array
        for (int i = 0; i < n; i++)
        {
            // If current element is zero
            if (arr[i] == 0)
            {
                // traverse j loop with i+1 and Look ahead for the next non-zero element and swap that non-zero elment with zero so zero push to the right side of the array
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] != 0)
                    {
                        // Swap arr[i] and arr[j]
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;

                        // Stop once we've swapped
                        break;
                    }
                }
            }
        }

        // Print the updated array
        Console.WriteLine("Array after moving zeros to end:");
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine(arr[j]);
        }
    }
}

// Array after moving zeros to end:
// 10
// 8
// 5
// 6
// 0
// 0

// Complexity: O(n^2) in the worst case, as we may have to traverse the array multiple times for each zero found.


//------------------------------    ------------------------------
//------------------------------    ------------------------------


//B. Effiencient Approach:
// Loop through the array.
// Use a count variable to keep track of the next position to place a non-zero element.
// If a non-zero element is found at index i, swap it with the element at index count, then increment count.
// At the end, all non-zero elements will be at the front, and all zeros will be moved to the end.

using System;

public class LeftRotateArrayByOne
{
    public static void Main(String[] args)
    {
        // Input array
        int[] arr = { 10, 8, 0, 0, 5, 6 };

        // Get the length of the array
        int n = arr.Length;

        // Call the function to move zeros to the end
        MoveToEnd(arr, n);
    }

    // Function to move all zeros to the end of the array
    static void MoveToEnd(int[] arr, int n)
    {
        // 'count' keeps track of index to place the next non-zero element
        int count = 0;

        // Traverse the array
        for (int i = 0; i < n; i++)
        {
            // If current element is not zero, bring it to the front
            if (arr[i] != 0)
            {
                // Swap arr[i] with arr[count] if needed
                int temp = arr[count];
                arr[count] = arr[i];
                arr[i] = temp;

                // Move 'count' to next position
                count++;
            }
        }

        // Print the updated array
        Console.WriteLine("Array after moving zeros to end:");
        for (int j = 0; j < n; j++)
        {
            Console.WriteLine(arr[j]);
        }
    }
}


/*
OUTPUT"
Array after moving zeros to end:
10      
8
5
6
0
0

/*

//Naive Easy Approach: