
    /*
    ============================================
    🚀 APPROACH (Kadane’s Algorithm)
    ============================================
    Solution 1: Optimized Kadane’s Algorithm (O(n) time, O(1) space)

    We iterate through the array and at each index we decide:

    👉 Either:
       1. Start a new subarray from current element
       2. Continue the previous subarray

    So:
    currSum = max(arr[i], currSum + arr[i])

    We keep updating the global maximum:
    maxSum = max(maxSum, currSum)

    This ensures we always track the best subarray sum.

    ============================================
    ⏱ TIME COMPLEXITY:
    O(n) → Single pass through the array

    🧠 SPACE COMPLEXITY:
    O(1) → No extra space used

    ============================================
    📌 DRY RUN:
    Input: [-3, -2, -6, -1, -7, -4]

    Step-by-step:

    i=0:
    currSum = -3, maxSum = -3

    i=1:
    currSum = max(-2, -3 + -2 = -5) = -2
    maxSum = max(-3, -2) = -2

    i=2:
    currSum = max(-6, -2 + -6 = -8) = -6
    maxSum = max(-2, -6) = -2

    i=3:
    currSum = max(-1, -6 + -1 = -7) = -1
    maxSum = max(-2, -1) = -1

    i=4:
    currSum = max(-7, -1 + -7 = -8) = -7
    maxSum = max(-1, -7) = -1

    i=5:
    currSum = max(-4, -7 + -4 = -11) = -4
    maxSum = max(-1, -4) = -1

    Final Answer = -1

    ============================================
    ✅ OUTPUT:
    -1
    ============================================
    */

using System;

class Solution {

    public int maxSubarraySum(int[] arr) {
        // Initialize with first element
        int maxSum = arr[0];
        int currSum = arr[0];
        
        // Traverse the array starting from index 1
        for(int i = 1; i < arr.Length; i++){
            
            // Decide whether to start new subarray or extend previous
            currSum = Math.Max(arr[i], currSum + arr[i]);
            
            // Update the maximum sum found so far
            maxSum = Math.Max(maxSum, currSum);
        }
        
        // Return the maximum subarray sum
        return maxSum;
    }

    // Main method to execute the program
    public static void Main(string[] args) {
        
        // Sample input
        int[] arr = { -3, -2, -6, -1, -7, -4 };

        // Create object of Solution class
        Solution obj = new Solution();

        // Call method
        int result = obj.maxSubarraySum(arr);

        // Print output
        Console.WriteLine("Maximum Subarray Sum: " + result);
    }
}
/*
OUTPUT:
-1
*/

//------------------------------------------------------------

/*
Solution 2: brute-force approach (O(n^2) time, O(1) space)

    /*
    ============================================
    🚀 APPROACH (Brute Force - All Subarrays)
    ============================================
    We generate all possible subarrays and calculate their sums.

    Steps:
    1. Fix a starting index (i)
    2. Extend subarray till every possible ending index (j)
    3. Keep adding elements to get sum
    4. Track maximum sum found

    ============================================
    ⏱ TIME COMPLEXITY:
    O(n²) → Two nested loops

    🧠 SPACE COMPLEXITY:
    O(1) → No extra space used

    ============================================
    📌 DRY RUN:
    Input: [-3, -2, -6, -1, -7, -4]

    Start:
    largestSum = -3

    i=0:
      j=0 → sum=-3 → largestSum=-3
      j=1 → sum=-5 → largestSum=-3
      j=2 → sum=-11 → largestSum=-3
      j=3 → sum=-12 → largestSum=-3
      j=4 → sum=-19 → largestSum=-3
      j=5 → sum=-23 → largestSum=-3

    i=1:
      j=1 → sum=-2 → largestSum=-2
      j=2 → sum=-8 → largestSum=-2
      j=3 → sum=-9 → largestSum=-2
      j=4 → sum=-16 → largestSum=-2
      j=5 → sum=-20 → largestSum=-2

    i=2:
      j=2 → sum=-6 → largestSum=-2
      ...

    i=3:
      j=3 → sum=-1 → largestSum=-1  ✅ (best)
      j=4 → sum=-8 → largestSum=-1
      j=5 → sum=-12 → largestSum=-1

    Final Answer = -1

    ============================================
    ✅ OUTPUT:
    -1
    ============================================
    */

// using System;

// class Solution {
//     public int maxSubarraySum(int[] arr) {
//         int largestSum = arr[0];
        
//         // Fix starting index
//         for(int i = 0; i < arr.Length; i++){
//             int sum = 0;
            
//             // Extend subarray
//             for(int j = i; j < arr.Length; j++){
//                 sum += arr[j];
                
//                 // Update maximum sum
//                 if(sum > largestSum){
//                     largestSum = sum;
//                 }
//             }
//         }
//         return largestSum;
//     }

//     // Main method
//     public static void Main(string[] args) {

//         // Sample input
//         int[] arr = { -3, -2, -6, -1, -7, -4 };

//         Solution obj = new Solution();

//         int result = obj.maxSubarraySum(arr);

//         Console.WriteLine("Maximum Subarray Sum: " + result);
//     }
// }

/*
OUTPUT:
-1
*/