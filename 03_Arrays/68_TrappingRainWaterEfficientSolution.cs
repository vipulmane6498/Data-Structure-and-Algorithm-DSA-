// Approach:
/*
Trapping Rain Water:


If the array is increasing order then water will not be trapped so the output will be 0
e.g. {1,2,3,4,5} -> output: 0

        |    
      | |    
    | | |    
  | | | |    
| | | | |    
------------
1 2 3 4 5

if the array is decreasing order then water will not be trapped so the output will be 0
e.g. {5,4,3,2,1} -> output: 0

|        
| |      
| | |    
| | | |  
| | | | |
_____________
5 4 3 2 1
*/
//TrappingRainWaterEfficientSolution
// We want to calculate how much rainwater is trapped between bars of different heights.
// Instead of checking left and right max for every element again and again (slow method),
// we first create two helper arrays:
//   1. lmax[i] = tallest bar from the left up to index i.
//   2. rmax[i] = tallest bar from the right up to index i.
// Then, water trapped on a bar = min(lmax[i], rmax[i]) - height[i].
// Finally, we add this water for all bars to get the answer.


//Efficient Solution: O(n) time complexity and O(n) space complexity
// We use precomputed lmax and rmax arrays to find trapped water in a single pass
using System;

public class TrappingRainWaterEfficientSolution
{
    public static void Main(string[] args)
    {
        // Heights of bars
        // int[] arr = {3, 0, 2, 5, 1, 3, 0, 4};  // Example 1
        int[] arr = { 5, 0, 6, 2, 3 };              // Example 2

        // Find number of bars
        int n = arr.Length;

        // result will store the total trapped water
        int result = 0;

        // Arrays to store left max and right max for each index
        int[] lmax = new int[n];
        int[] rmax = new int[n];

        // Step 1: Fill lmax array
        // First element of lmax is same as first element of arr
        lmax[0] = arr[0];

        //to store the elemnt we will traverse from 1 to n-1 , left to right both the arrays arr and lmax
        // because lmax at any index will be max of (previous lmax and current arr
        // For every position, store the maximum of (previous lmax and current bar)
        for (int j = 1; j < n; j++)
        {
            lmax[j] = Math.Max(lmax[j - 1], arr[j]);
        }

        // Step 2: Fill rmax array
          //to store the elemnt we will traverse from n-2 to 0 , right to left both the arrays arr and rmax
        // because rmax at any index will be max of (next rmax and current arr
        // Last element of rmax is same as last element of arr
        rmax[n - 1] = arr[n - 1];

        // For every position (going backwards), 
        // store the maximum of (next rmax and current bar)
        for (int j = n - 2; j >= 0; j--)
        {
            rmax[j] = Math.Max(rmax[j + 1], arr[j]);
        }

        // Step 3: Calculate trapped water using lmax and rmax
        for (int i = 1; i < n; i++)
        {
            // trapped water = min(lmax[i], rmax[i]) - arr[i]
            result = result + (Math.Min(lmax[i], rmax[i]) - arr[i]);
        }

        // Print the total trapped water
        System.Console.WriteLine("Trapped water is: " + result + " units !");


        /*
        Dry Run for arr = {5, 0, 6, 2, 3}

        Step 1: Calculate lmax
        lmax[0] = 5
        lmax[1] = max(5, 0) = 5
        lmax[2] = max(5, 6) = 6
        lmax[3] = max(6, 2) = 6
        lmax[4] = max(6, 3) = 6
        => lmax = {5, 5, 6, 6, 6}

        Step 2: Calculate rmax
        rmax[4] = 3
        rmax[3] = max(3, 2) = 3
        rmax[2] = max(3, 6) = 6
        rmax[1] = max(6, 0) = 6
        rmax[0] = max(6, 5) = 6
        => rmax = {6, 6, 6, 3, 3}

        Step 3: Calculate trapped water
        i=1: water = min(5, 6) - 0 = 5
        i=2: water = min(6, 6) - 6 = 0
        i=3: water = min(6, 3) - 2 = 1
        i=4: water = min(6, 3) - 3 = 0

        Total water = 5 + 0 + 1 + 0 = 6 units

        Final Answer: Trapped water is 6 units !
        */
    }
}

/*
Output:
Trapped water is: 6 units !
*/
