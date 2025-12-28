using System;

class SecondLargest
{
    // Method to find the index of the second largest element in the array
    public int secondlargestIndex(int[] a, int n)
    {
        int Firstlargest = 0;  // Index of the largest element
        int Secondlargest = -1; // Index of the second largest element (initialized to -1)

        for (int i = 1; i < n; i++)
        {
            // If current element is larger than the largest found so far
            if (a[i] > a[Firstlargest])
            {
                Secondlargest = Firstlargest; // Previous largest becomes second largest
                Firstlargest = i; // Update largest index
            }
            // If the current element is smaller than the largest but greater than second largest
            else if (a[i] != a[Firstlargest]) // Ensure it's not equal to the largest
            {
                if (Secondlargest == -1 || a[i] > a[Secondlargest]) // Update second largest
                    Secondlargest = i;
            }
        }

        return Secondlargest; // Return the index of the second largest element
    }

    public static void Main()
    {
        SecondLargest obj = new SecondLargest(); // Corrected instantiation

        // Step 1: Read input for the size of the array
        int n = int.Parse(Console.ReadLine());

        int[] a = new int[n]; // Step 2: Declare an array of size n

        // Step 3: Read n elements into the array
        for (int i = 0; i < n; i++)
        {
            a[i] = int.Parse(Console.ReadLine());
        }

        // Step 4: Find the index of the second largest element
        int pos = obj.secondlargestIndex(a, n);

        // Step 5: Handle case where there is no second largest element
        if (pos != -1)
            Console.WriteLine("Second Largest Element: " + a[pos]); // Print second largest
        else
            Console.WriteLine("No second largest element exists.");
    }
}
