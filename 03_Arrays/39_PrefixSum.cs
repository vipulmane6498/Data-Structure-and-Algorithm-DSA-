//Prefix Sum Effiecient Code:
//Prefix sum: Sum of given range
//e.g. arr[]={2,8,3,9,6,5,4} and a=1,b=3
//output=8+3+9=20


// ------------------------------------------------------
// Approach:
// The program calculates the sum of elements in a given range (a to b)
// using the Prefix Sum technique.
//
// Steps:
// 1. Create a prefix sum array (pr[]) such that each element pr[i]
//    represents the sum of all array elements from index 0 to i.
// 2. Once the prefix array is built:
//       • If a == 0 → return pr[b]
//       • Otherwise → return pr[b] - pr[a - 1]
//    This gives the sum of elements from index a to b efficiently.
// 3. This approach reduces repeated addition and allows O(1) range queries
//    after O(n) preprocessing.
// ------------------------------------------------------

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Define start and end indices of range
        int a = 0;
        int b = 3;
        
        // Input array
        int[] arr = {2, 8, 3, 9, 6, 5, 4};
        
        // Call preSum method to get sum from index a to b
        int res = preSum(arr, a, b);
        
        // Print the result
        System.Console.WriteLine(res);
    }
    
    // Method to calculate sum of elements between indices a and b using prefix sum
    static int preSum(int[] arr, int a, int b)
    {
        // Step 1: Create prefix sum array of same size as input array
        int[] pr = new int[arr.Length];
        
        // Step 2: Initialize first prefix value
        pr[0] = arr[0];

        // Step 3: Build prefix array by cumulative addition
        for (int i = 1; i < arr.Length; i++)
        {
            pr[i] = arr[i] + pr[i - 1];   // Each prefix element stores sum till that index

        } ////So, pr = {2, 10, 13, 22, 28, 33, 37}

        // Step 4: Use prefix sum formula to get range sum
        // If starting index is 0, directly return pr[b]
        //e.g. a=0,b=3 => pr[3]=22
        if (a == 0)
        {
            return pr[b];
        }

        // Otherwise, subtract prefix before the start index
        //e.g. a=1,b=3 => pr[3]-pr[0] => 22-2=20
        return pr[b] - pr[a - 1];
    }
}

/*
------------------------------------------------------
Dry Run:
arr = {2, 8, 3, 9, 6, 5, 4}
a = 0, b = 3

Step 1: Build prefix sum array
--------------------------------
pr[0] = arr[0] = 2
pr[1] = arr[1] + pr[0] = 8 + 2 = 10
pr[2] = arr[2] + pr[1] = 3 + 10 = 13
pr[3] = arr[3] + pr[2] = 9 + 13 = 22
pr[4] = arr[4] + pr[3] = 6 + 22 = 28
pr[5] = arr[5] + pr[4] = 5 + 28 = 33
pr[6] = arr[6] + pr[5] = 4 + 33 = 37

So, pr = {2, 10, 13, 22, 28, 33, 37}

Step 2: Compute sum in given range
-----------------------------------
Since a = 0 → result = pr[b] = pr[3] = 22

✅ Output = 22
------------------------------------------------------
*/



// -----------------------------------------------



//prefix sum approach (basic form) naive Solution
// Approach:
// This program calculates the sum of array elements 
// between two given indices 'a' and 'b' (inclusive) 
// using a simple loop — also called the Prefix Sum approach (basic form).
// 
// Steps:
// 1. Take input array and two indices (a, b).
// 2. Initialize result = 0.
// 3. Traverse the array from index 'a' to 'b'.
// 4. Add each element to result.
// 5. Return the final result as the sum of elements in the given range.
// -----------------------------------------------
/*
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        // Define start and end indices for the sum range
        int a = 1;
        int b = 3;
        
        // Input array
        int[] arr = {2, 8, 3, 9, 6, 5, 4};
        
        // Call preSum method to find the sum between index 1 and 3
        int res = preSum(arr, a, b);
        
        // Print the result
        System.Console.WriteLine(res);
    }
    
    // Method to calculate sum of elements between indices a and b
    static int preSum(int[] arr, int a, int b)
    {
        int result = 0;  // Variable to store cumulative sum
        
        // Loop from index 'a' to 'b' (inclusive)
        for (int i = a; i <= b; i++)
        {
            result = result + arr[i];  // Add current element to result
        }
        
        // Return the total sum in the given range
        return result;
    }
}
*/
/*
Dry Run Example:
----------------
arr = {2, 8, 3, 9, 6, 5, 4}
a = 1, b = 3

Iteration:
i = 1 → result = 0 + 8 = 8
i = 2 → result = 8 + 3 = 11
i = 3 → result = 11 + 9 = 20

Final Output: 20
*/
