// 

//Trapping Rain Water Naive Solution:

//Approach:
// The problem is about finding how much rainwater can be trapped between bars of different heights.
// Imagine the array as vertical bars where water can stay between taller bars.
// For each bar (except the first and last), we check:
//   1. The tallest bar to the left of it (Lmax).
//   2. The tallest bar to the right of it (Rmax).
// The water that can be stored on top of the bar = min(Lmax, Rmax) - height of current bar.
// We do this for all bars and add them to get total trapped water.


//naive Solution: O(n^2) time complexity
// We use two nested loops to find Lmax and Rmax for each bar.

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Heights of bars (like walls where water can be trapped)
        int[] heightArr = {3, 0, 2, 5, 1, 3, 0, 4};

        // n = number of bars
        int n = heightArr.Length;

        // result will store the total trapped water
        int result = 0;

        // We skip first and last bar, as water cannot be trapped on edges
        for(int i = 1; i < n - 1; i++)
        {
            // Assume current bar height as lmax (max on left side)
            int lmax = heightArr[i];

            // Find actual tallest bar on the left side of i
            for(int j = 0; j < i; j++)
            {
                lmax = Math.Max(lmax, heightArr[j]);
            }

            // Assume current bar height as rmax (max on right side)
            int rmax = heightArr[i];

            // Find actual tallest bar on the right side of i
            for(int j = i + 1; j < n; j++)
            {
                rmax = Math.Max(rmax, heightArr[j]);
            }

            // Water trapped at current index = min(lmax, rmax) - current height
            result = result + (Math.Min(lmax, rmax) - heightArr[i]);
        }

        // Print final trapped water
        System.Console.WriteLine("Trapped water is: " + result + " units !");


        /*
        Dry Run for input {3, 0, 2, 5, 1, 3, 0, 4}:

        i = 1 (bar height = 0)
        lmax = 3 (tallest on left)
        rmax = 5 (tallest on right)
        Water = min(3, 5) - 0 = 3
        result = 3

        i = 2 (bar height = 2)
        lmax = 3
        rmax = 5
        Water = min(3, 5) - 2 = 1
        result = 4

        i = 3 (bar height = 5)
        lmax = 5
        rmax = 5
        Water = min(5, 5) - 5 = 0
        result = 4

        i = 4 (bar height = 1)
        lmax = 5
        rmax = 4
        Water = min(5, 4) - 1 = 3
        result = 7

        i = 5 (bar height = 3)
        lmax = 5
        rmax = 4
        Water = min(5, 4) - 3 = 1
        result = 8

        i = 6 (bar height = 0)
        lmax = 5
        rmax = 4
        Water = min(5, 4) - 0 = 4
        result = 12

        Final Answer: 12 units of water trapped
        */
    }
}
