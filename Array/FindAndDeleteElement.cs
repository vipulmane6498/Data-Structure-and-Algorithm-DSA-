// Find and delete the element
// Approach: 
// Compare each element in the array with "remove".
// If the element is found, replace it with the next element in the array.

using System;

public class FindAndDeleteElement
{
    public static void Main(string[] args)
    {
        // Step 1: Define the original array
        int[] arr = {1, 2, 3, 4, 5}; 
        int size = arr.Length; // Get the size of the original array

        int remove = 4; // The element to be removed
        
        // Step 2: Loop through the array to find the element to remove
        for(int i = 0; i < arr.Length; i++)
        {
            if(arr[i] == remove) // If the current element matches "remove"
            {
                arr[i] = arr[i + 1]; // Replace it with the next element
            }
        }
        
        // Step 3: Print the updated array (Note: The array size is unchanged)
        Console.WriteLine("Updated array after inserting the element at the end:");
        for (int j = 0; j < arr.Length; j++) 
        {
            Console.Write(arr[j] + " "); // Print each element
        }
    }
}

/*
Expected Output (but incorrect logic):
1 2 3 5 5  

Issue: The array size remains the same, and only one element is shifted.
*/

//--------------------------------------------------------------------------------------------------------------
//2nd Code:
// Find and delete the element from the array
// Approach: 
// 1. Create a new array with a size smaller than the original array.
// 2. Traverse the original array and copy all elements except the one to be removed.
// 3. Print the updated array.

using System;

public class FindAndDeleteElement
{
    public static void Main(string[] args)
    {
        // Step 1: Define the original array
        int[] arr = {1, 2, 3, 4, 5}; 
        int size = arr.Length; // Get the size of the original array

        int remove = 4; // The element to be removed
        
        int newSize = size - 1; // New array size after removal
        
        int[] newArr = new int[newSize]; // Create a new array to store elements after deletion
        
        int newIndex = 0; // Index to track position in the new array

        // Step 2: Traverse the original array
        for(int i = 0; i < size; i++)
        {
            if(arr[i] != remove) // If current element is not the one to remove
            {
                if(newIndex < newSize) // Ensure we don't go beyond the new array size
                {
                    newArr[newIndex] = arr[i]; // Copy element to new array
                    newIndex++; // Move to the next position
                }
            }
        }
     
        // Step 3: Print the updated array
        Console.WriteLine("Updated array after removing the element:");
        for (int j = 0; j < newArr.Length; j++) 
        {
            Console.Write(newArr[j] + " "); // Print each element
        }
    }
}

/*
Expected Output:
1 2 3 5
*/
