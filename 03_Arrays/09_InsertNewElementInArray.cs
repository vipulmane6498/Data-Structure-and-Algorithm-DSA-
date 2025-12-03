// Inserting an element at the end of the array.

// Approach
// Define the Original Array:
// Create a New Array with Extra Space:
// Copy Elements from the Old Array to the New One:
// Insert the New Element:
// Print the Updated Array:

using System;

public class InsertNewElementInArray
{
    public static void Main(string[] args)
    {
        // Step 1: Define the original array
        int[] arr = {1, 2, 3, 4, 5}; 
        int size = arr.Length; // Get the size of the original array

        // Step 2: Define the new element to be added
        int newElement = 6;

        // Step 3: Create a new array with one extra space
        int[] newArr = new int[size + 1]; 
        int newSize = newArr.Length; // Get the size of the new array

        // Step 4: Copy elements from the original array to the new array
        for (int i = 0; i < size; i++) 
        {
            newArr[i] = arr[i]; // Copying each element
        }

        // Step 5: Insert the new element at the last position
        newArr[newSize - 1] = newElement;

        // Step 6: Print the updated array
        Console.WriteLine("Updated array after inserting the element at the end:");
        for (int j = 0; j < newSize; j++) 
        {
            Console.Write(newArr[j] + " "); // Print each element
        }
    }
}
/*
1
2
3
4
5
6
*/
