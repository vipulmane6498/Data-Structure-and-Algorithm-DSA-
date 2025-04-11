//Insert Element At Any Position In Array

// Approach 
// Take user input for array size and elements.
// Create a new array with size + 1 to store the updated elements.
// Iterate through the new array:
// If k == pos, insert newElement.
// Otherwise, copy elements from the old array (arr) using an index res to track original positions.
//Print the updated array.
using System;

public class InsertElementAtAnyPositionInArray
{
    public static void Main(string[] args)
    {
        // Step 1: Get the size of the original array from user input
        System.Console.WriteLine("Enter the size of the array: ");
        int size = Convert.ToInt32(System.Console.ReadLine());

        // Step 2: Declare an array of given size
        int[] arr = new int[size];

        // Step 3: Input elements into the array
        System.Console.WriteLine("Enter the elements of the array: ");
        for (int i = 0; i < size; i++) 
        {
            arr[i] = Convert.ToInt32(System.Console.ReadLine()); // Read each element
        }

        // Step 4: Define the position and new element to be inserted
        int pos = 2;  // Index at which we want to insert (0-based index)
        int newElement = 99;

        // Step 5: Create a new array with increased size to accommodate the new element
        int newSize = size + 1;
        int[] newArr = new int[newSize];

        int res = 0; // Pointer for accessing elements from the old array

        // Step 6: Copy elements from the old array while inserting the new element at the correct position
        for (int k = 0; k < newSize; k++)
        {
            if (k == pos)
            {
                newArr[k] = newElement; // Insert new element at the specified position
            }
            else
            {
                newArr[k] = arr[res]; // Copy elements from old array and its index name is res.  res = 0, 1, 2, etc
                res++; // Move to next element in the old array
            }
        }

        // Step 7: Print the updated array
        Console.WriteLine("Updated array after insertion:");
        for (int j = 0; j < newArr.Length; j++)
        {
            Console.Write(newArr[j] + " "); 
        }
    }
}

/*
Enter the size of the array: 
5
Enter the elements of the array: 
1
2
3
4
5
Updated array after insertion:
1 2 99 3 4 5 
*/
