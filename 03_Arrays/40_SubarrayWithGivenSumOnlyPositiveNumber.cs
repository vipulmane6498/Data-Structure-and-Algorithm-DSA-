// Subarray with Given Sum. Level: Easy 

//Efficient Solution: O(n) time complexity

using System;

public class SubarrayWithGivenSum
{
    /*
    ------------------------------------------------------------
    Approach: Sliding Window Technique
    ------------------------------------------------------------
    1. Maintain a running sum (currSum) of the current window.
    2. Expand the window by adding elements one by one.
    3. If currSum exceeds the target sum, shrink the window 
       from the left side by subtracting elements.
    4. If at any point currSum == target sum → return true.
    5. Continue until all elements are processed.

    In Short, keep adding elements to currSum until it exceeds the target sum. If it exceeds, keep removing elements from the start of the current window until currSum becomes equal to the target sum. If at any point currSum equals the target sum, return true.
    ✅ Time Complexity: O(n)
    ✅ Space Complexity: O(1)
    ------------------------------------------------------------
    */

    public static void Main(string[] args)
    {
        int[] arr = { 1, 4, 20, 3, 10, 5 };
        int sum = 33;
        bool isFound = Check(arr, sum);
        Console.WriteLine("Is Subarray with Given Sum Present? " + isFound);
    }

    static bool Check(int[] arr, int sum)
    {
        int newIndex = 0;  // Left pointer of the window
        int currSum = 0;   // Current window sum

        for (int i = 0; i < arr.Length; i++)
        {
            currSum += arr[i]; // Add current element to window

            // Shrink window when sum exceeds target
            while (currSum > sum)
            {
                currSum -= arr[newIndex];
                newIndex++;
            }

            // If exact sum found
            if (currSum == sum)
                return true;
        }

        // -----------------------------
        // 🔍 Dry Run (arr = {1,4,20,3,10,5}, sum = 33)
        // -----------------------------
        /*
        Step 1: i=0 → currSum=1
        Step 2: i=1 → currSum=5
        Step 3: i=2 → currSum=25
        Step 4: i=3 → currSum=28
        Step 5: i=4 → currSum=38 > 33
                → Subtract arr[0]=1 → currSum=37
                → Subtract arr[1]=4 → currSum=33 ✅ Found!
        Output: True
        */

        return false; // No subarray found
    }
}
/*
OUTPUT:
True
*/




//----------------------------------
//Naive Solution: O(n^2) time complexity
/*
Approach:
1. Iterate through each element of the array as a starting point.
2. For each starting point, iterate through the subsequent elements, maintaining a running sum.
3. If the running sum equals the target sum at any point, return true.
/*

*/

/*
using System;

public class SubarrayWithGivenSum
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 4, 20, 3, 10, 5 };
        int sum = 33;
        bool isK = Check(arr, sum);
        System.Console.WriteLine(isK);

    }
    static bool Check(int[] arr, int sum)
    {
        bool isSum = false;
        for (int i = 0; i < arr.Length; i++)
        {
            int result = 0;
            for (int j = i; j < arr.Length; j++)
            {
                result = result + arr[j];
                if (result > sum)
                {
                    break;
                }
                if (result == sum)
                {
                    return true;
                }
            }
        }
        return false;
    }
}
/*
OUTPUT:
True
*/