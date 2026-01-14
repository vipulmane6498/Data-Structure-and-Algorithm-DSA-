
/*
Mean and Median of an Array
Level: Easy
------------------------------------
Question:
Given an array of positive integer arr[]. Find the mean and median of the array. 
Where mean is the average value of the given array, median is the average of the two middle elements.

Example 1:
Input: arr[] = [1, 2, 19, 28, 5]
Output: 11 5
Explanation: mean is (1 + 2 + 19  + 28  + 5)/5 = 11.
median is 5 (middle element after sorting)

Example 2:
Input: arr[] = [2, 8, 3, 4]
Output: 4 3
Explanation: mean is floor ((2 + 8 + 3 + 4)/4) = 4.
median is floor ((3 + 4)/2) = 3

-------------------------
Approach:

We are required to calculate the Mean and Median of an integer array.

1. Mean:
   - Add all numbers in the array.
   - Divide the sum by the total number of elements.

2. Median:
   - Sort the array.
   - If the count is odd → median is the middle element.
   - If the count is even → median is the average of the two middle elements.
*/

using System;
class MeanAndMedianOfArray
{
    public static void Main(string[] args)
    {
        // Input array
        int[] arr = { 1, 2, 19, 28, 5 };

        // MEAN calculation
        int size = arr.Length;
        int n = 0;

        for (int i = 0; i < size; i++)
        {
            n = n + arr[i];
        }

        int mean = n / size; //mean

        // MEDIAN calculation
        Array.Sort(arr);
        int size2 = arr.Length;

        int median;

        if (size2 % 2 != 0)
        {
            median = arr[(size2 / 2)];
        }
        else
        {
            int result = arr[(size2 / 2) - 1] + arr[(size2 / 2)];
            median = result / 2;
        }

        // Output
        Console.WriteLine(mean + " " + median);
    }
}
/*
OUTPUT:
11 5

*/