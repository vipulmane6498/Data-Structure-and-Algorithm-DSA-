
/*
Strong Neighbour:
Given an array of integers, return a new array containing the maximum of each pair of adjacent elements in the original array.

Approach:
- We traverse the array from index 0 to n-2.
- For every pair of adjacent elements (arr[i], arr[i+1]):
    → Compare both elements
    → Add the maximum of the two into a result list
- Return the final list containing maximums of all adjacent pairs

Example:
Input:  [1, 3, 2, 5, 4]
Pairs:  (1,3), (3,2), (2,5), (5,4)
Output: [3, 3, 5, 5]

Time Complexity:
- O(n) → We traverse the array once

Space Complexity:
- O(n) → We store n-1 elements in the result list
*/

using System;
using System.Collections.Generic;
class Solution {

    // Function to get max of adjacent elements
    public List<int> maxAdj(int[] arr) {

        // Create list to store results
        List<int> list = new List<int>();

        // Loop through array till second last element
        for(int i = 0; i < arr.Length - 1; i++) {

            // Compare adjacent elements
            if(arr[i] > arr[i + 1]) {
                // Add current element if greater
                list.Add(arr[i]);
            }
            else {
                // Add next element if greater or equal
                list.Add(arr[i + 1]);
            }
        }

        // Return final list
        return list;
    }
}

class Program {
    static void Main(string[] args) {

        // Create object of Solution class
        Solution sol = new Solution();

        // Input array
        int[] arr = {1, 3, 2, 5, 4};

        // Call function
        List<int> result = sol.maxAdj(arr);

        // Print output
        Console.WriteLine("Output:");
        foreach(int num in result) {
            Console.Write(num + " ");
        }
    }
}
/*

Output:
3 3 5 5

*/