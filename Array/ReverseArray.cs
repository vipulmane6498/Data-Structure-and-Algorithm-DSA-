
// Reverse Array

// Apprach:

// Step 1: Take Input from User
// a. Ask the user to enter the size of the array (n).
// b. Declare an array of size n.
// c. Use a loop to take n integer inputs from the user and store them in the array.

// Step 2: Initialize Two Pointers
// Set low = 0 → Points to the first element..
// Set high = n - 1 → Points to the last element.

// Step 3: Swap Elements Using a While Loop
// Repeat until low < high:
// Swap the elements at low and high indices.
// Move low forward (low++).
// Move high backward (high--)

using System;

public class ArrayReverse
{
    public static void Main()
    {
        // Prompt the user to enter the size of the array
        System.Console.WriteLine("Enter the size of the array: ");
        
        // Read the input from the user, convert it to an integer, and store it in 'n'
        int n = Convert.ToInt32(System.Console.ReadLine());

        // Declare an integer array of size 'n'
        int[] arr = new int[n];

        // Prompt the user to enter 'n' numbers
        System.Console.WriteLine("Enter only " + n + " numbers in the array: ");

        // Loop to take 'n' inputs from the user and store them in the array
        for (int i = 0; i < n; i++)
        {
            arr[i] = Convert.ToInt32(System.Console.ReadLine());
        }

        // Initialize two pointers: 
        // 'low' starts from the beginning (index 0)
        // 'high' starts from the end (index n-1)
        int low = 0;
        int high = n - 1;

        // Swap elements until the two pointers meet in the middle
        while (low < high)
        {
            // Swap arr[low] and arr[high]
            int temp = arr[low];
            arr[low] = arr[high];
            arr[high] = temp;

            // Move the 'low' pointer forward
            low++;

            // Move the 'high' pointer backward
            high--;
        }

        // Print the reversed array
        System.Console.WriteLine("Following is the reversed Array: ");
        for (int j = 0; j < n; j++)
        {
            System.Console.Write(arr[j] + " ");
        }
    }
}

/*
Example Execution:

Enter the size of the array: 
5
Enter only 5 numbers in the array: 
1
2
3
4
5
Following is the reversed Array: 
5 4 3 2 1
*/

/*
Enter the size of the array: 
5
Enter only 5  numbers in the array: 
1
2
3
4
5
Following is the reversed Array: 
5 4 3 2 1 
*/