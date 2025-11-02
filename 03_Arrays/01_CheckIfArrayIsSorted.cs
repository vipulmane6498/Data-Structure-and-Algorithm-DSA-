// Apparch:
// Just apply loop and check if prevouis number is greater than next number then its not sorted array
using System;

public class CheckIfArrayIsSorted
{
    public static void Main(String[] args)
    {
        // Prompt the user to enter the size of the array
        System.Console.WriteLine("Enter the size of the array: ");
        
        // Read the input and convert it to an integer
        int n = Convert.ToInt32(System.Console.ReadLine());

        // Declare an array of size 'n'
        int[] arr = new int[n];

        // Prompt the user to enter 'n' elements
        System.Console.WriteLine("Enter " + n + " numbers in the array:");
        
        for (int i = 0; i < n; i++)
        {
            // Read and store each element in the array
            arr[i] = Convert.ToInt32(System.Console.ReadLine());
        }

        // Assume initially that the array is sorted
        bool sort = true;

        // Loop through the array from the second element to the last
        for (int i = 1; i < arr.Length; i++)
        {
            // Compare the previous element (arr[i-1]) with the current element (arr[i])
            // If arr[i-1] is greater than arr[i], the array is not sorted
            if (arr[i - 1] > arr[i])
            {
                sort = false; // Set the flag to false, meaning the array is unsorted
                break; // Exit the loop early since we already found the array is unsorted
            }
        }

        // Print the result based on the 'sort' flag
        if (sort == true)
        {
            System.Console.WriteLine("Array is Sorted"); // If flag remains true, array is sorted
        }
        else
        {
            System.Console.WriteLine("Array is not sorted!"); // If flag is false, array is unsorted
        }
    }
}
/*
Enter the size of the array: 
5
Enter 5 numbers in the array:
1
2
3
2
4
Array is not sorted!
*/