// Approach:
// Input the array – Read n elements from the user.
// Sort the array – Use Bubble Sort to arrange elements in ascending order using temp variable\.
// Remove duplicates – Check if current element is not same as previous element  then add this current unique element in the new pointer and then increament the pointer for to store next unique element. Use a pointer res to track unique elements and overwrite duplicates in the same array.
// Print the final array – Only print the unique elements.




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
        
        // Step 4: Sorting Logic using Bubble Sort (Ascending Order)---------------------------------
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

        // Step 5: Removing duplicate elements from the sorted array-----------------------------------------
        int res = 1; // Pointer to track unique elements in the same array
        for (int i = 1; i < arr.Length; i++)
        {
        //Check for uniqueness:-
        //keeping 1st element in its position as it is bcoz its lowest unique number for us and then checking for the next element.
        // If arr[i] is not equal to arr[i - 1], it means it's a unique element.
        // Store it at the res index: arr[res] = arr[i].
        // Move res forward (res++) to prepare for the next unique value.
            if (arr[i] != arr[i - 1]) // Compare current element with previous element
            {
                arr[res] = arr[i]; // Store unique element at the new position in the same array
                res++; // Move pointer forward
            }
        }

        // Step 6: Print the sorted array without duplicates
        System.Console.WriteLine("Sorted array without duplicates:");
        for (int i = 0; i < res; i++)
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
3
4
Sorted array without duplicates:
1 2 3 4 
*/