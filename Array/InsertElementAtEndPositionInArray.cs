using System;

public class InsertElementAtEndOfArray
{
    public static void Main(string[] args)
    {
        // Step 1: Get the size of the original array from user input
        Console.WriteLine("Enter the size of the array: ");
        int size = Convert.ToInt32(Console.ReadLine());

        // Step 2: Declare an array of given size
        int[] arr = new int[size];

        // Step 3: Input elements into the array
        Console.WriteLine("Enter the elements of the array: ");                                                                         
        for (int i = 0; i < size; i++) 
        {
            arr[i] = Convert.ToInt32(Console.ReadLine()); // Read each element
        }

        // Step 4: Define the new element to be inserted at the end
        int newElement = 99;

        // Step 5: Create a new array with increased size to accommodate the new element
        int newSize = size + 1;
        int[] newArr = new int[newSize];

        // Step 6: Copy elements from the old array to the new one
        for (int i = 0; i < size; i++)
        {
            newArr[i] = arr[i];
        }

        // Step 7: Add the new element at the end
        newArr[newSize - 1] = newElement;

        // Step 8: Print the updated array
        Console.WriteLine("Updated array after insertion at the end:");
        for (int j = 0; j < newArr.Length; j++)
        {
            Console.Write(newArr[j] + " "); 
        }
    }
}
