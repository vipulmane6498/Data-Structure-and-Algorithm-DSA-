// Approach:
//Find the index position where the largest number exist so return its index number.

// Approach to Finding the Index of the Largest Element
// ✅ 1. Initialize the index (res) to track the largest element for the same array
 // Start with res = 0, assuming the first element is the largest initially.

// ✅ 2. Traverse the array from the second element (i = 1 to n-1)
// Compare each element arr[i] with the current largest arr[res].

// ✅ 3. Update the index (res) when a larger element is found
// If arr[i] > arr[res], update res = i.

// ✅ 4. At the end of the loop, res holds the index of the largest element.
// Print the result: "Largest element index number is: " + res.

using System;

public class CheckIfArrayIsSorted
{
    public static void Main(String[] args)
    {
        // Step 1: Prompt the user to enter the size of the array
        System.Console.WriteLine("Enter the size of the array: ");

        // Read user input and convert it to an integer
        int n = Convert.ToInt32(System.Console.ReadLine());

        // Step 2: Declare an array of size 'n'
        int[] arr = new int[n];

        // Step 3: Prompt the user to enter 'n' elements
        System.Console.WriteLine("Enter " + n + " numbers in the array:");

        for (int i = 0; i < n; i++)
        {
            // Read and store each element in the array
            arr[i] = Convert.ToInt32(System.Console.ReadLine());
        }
        
        // Step 4: Initialize variable to track the index of the largest element
        int res = 0; // Assume the first element is the largest initially

        // Step 5: Traverse the array to find the index of the largest element
        for (int i = 1; i < arr.Length; i++)
        {
            // Compare the current element with the largest element found so far
            if (arr[i] > arr[res])
            {
                // Update 'res' with the index of the new largest element
                res = i;
            }
        }

        // Step 6: Output the index of the largest element
        System.Console.WriteLine("Largest element index number is: " + res);
    }
}

/*
Enter the size of the array: 
5
Enter 5 numbers in the array:
1
2
1
3
2
Largest element index number is: 3
*/