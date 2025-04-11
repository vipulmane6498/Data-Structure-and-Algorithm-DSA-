// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler
//Merge Sorted Array
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] num1 = { 1, 2, 3, 0, 0, 0 };

        int[] num2 = { 2, 5, 6 };


        int m = num1.Length;

        int n = num2.Length;

        Merge(num1, m, num2, n);

    }

    static void Merge(int[] num1, int m, int[] num2, int n)
    {

        int finalSize = m + n;

        int[] finalArray = new int[finalSize];

        int res = 0; //this pointer is used to add elements to the final array
        //Add 1st array to final array
        for (int i = 0; i < m; i++)
        {
            if (num1[i] != 0)
            {
                finalArray[res] = num1[i];
                res++;
            }
        }


        //Add 2nd array to final array
        for (int j = 0; j < n; j++)
        {
            finalArray[res] = num2[j];
            res++;
        }

        for (int i = 0; i < m; i++)
        {
            System.Console.WriteLine(finalArray[i]);
        }

        // Sort the final array using bubble sort
        // Bubble sort
        for (int i = 0; i < res - 1; i++)
        {
            for (int j = 0; j < res - i - 1; j++)
            {
                if (finalArray[j] > finalArray[j + 1])
                {
                    int temp = finalArray[j];
                    finalArray[j] = finalArray[j + 1];
                    finalArray[j + 1] = temp;
                }
            }

        }

        System.Console.WriteLine("Merge Sorte Array: ");
        for (int i = 0; i < res; i++)
        {
            System.Console.WriteLine(finalArray[i]);
        }

    }
}

/*

Merge Sorte Array: 
1
2
2
3
5
6


*/

// Another solution:

// public class Solution {
//     public void Merge(int[] nums1, int m, int[] nums2, int n) {
//       for (int j = 0, i = m; j < n; j++) //here m is the count of valid elements, not the last index.//
//     {
//             nums1[i] = nums2[j];
//             i++;
//         }
//         Array.Sort(nums1);
//     }
// }