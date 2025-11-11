// Sort the given array
// Approach:

// check if current number is greater than previous number
// if yes then swap both

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

        // Step 4: Sorting Logic using Element Swapping
        for (int i = 1; i < arr.Length; i++)
        {
            // If the current element is smaller than the previous element, swap them
            if (arr[i - 1] > arr[i])
            {
                // Swap arr[i-1] and arr[i]
                int temp = arr[i - 1];
                arr[i - 1] = arr[i];
                arr[i] = temp;
            }
        }

        // Step 5: Print the sorted array
        System.Console.WriteLine("Print the sorted Array: ");
        for (int i = 0; i < n; i++)
        {
            System.Console.Write(arr[i] + " ");
        }
    }
}

/*
Enter the size of the array: 
5
Enter 5 numbers in the array:
1
3
2
7
5
Print the sorted Array: 
1 2 3 5 7 
*/