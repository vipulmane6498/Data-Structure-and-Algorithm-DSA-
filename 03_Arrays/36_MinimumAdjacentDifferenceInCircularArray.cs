    /*

    Problem: Minimum Adjacent Difference in Circular Array -easy

    Given a circular array of integers, find the minimum absolute difference between adjacent elements.
    Example:
    Input: arr = [8, -8, 9, -9, 10, -11, 12]
    Output: 1
     Explanation: The absolute difference between adjacent elements in the given array are as such: 16 17 18  19 21 23 4 (first and last). Among the calculated absolute difference the minimum is 4.

    Detailed Explanation: The minimum adjacent difference is between between 
        1. 8 and -8 (|8 - (-8)| = 16) or
        2. -8 and 9 (|-8 - 9| = 17) or
        3. 9 and -9 (|9 - (-9)| = 18) or
        4. -9 and 10 (|-9 - 10| = 19) or
        5. 10 and -11 (|10 - (-11)| = 21) or
        6. -11 and 12 (|-11 - 12| = 23) or
        7. 12 and 8 (|12 - 8| = 4) **circular case** last to first element

        Minimum of these differences is 1, which occurs between 9 and -9.

    
    
    APPROACH:

    1. Create a new array (newArr) to store absolute differences 
       between adjacent elements.

    2. Traverse the given array from index 0 to n-2:
       - Find difference between arr[i] and arr[i+1]
       - Convert it into absolute value manually (if negative → make positive)
       - Store it in newArr

    3. Handle circular condition:
       - Find difference between last element (arr[n-1]) and first element (arr[0])
       - Convert to absolute and store in newArr

    4. Initialize result with first element of newArr

    5. Traverse newArr and find the minimum value

    6. Return the minimum adjacent difference

    Time Complexity: O(n)
    Space Complexity: O(n)
    */



using System;

class Solution {

   
   

    // Function to find minimum adjacent difference in a circular array.
    public int minAdjDiff(int[] arr, int n) {
        
        // Step 1: create array to store differences
        int[] newArr = new int[n];
        
        int pos = 0; // pointer to fill newArr
        
        // Step 2: compute difference between adjacent elements
        for(int i = 0; i < n - 1; i++){
            
            int diff = arr[i] - arr[i + 1]; // difference
            
            // Step 3: convert to absolute value manually -> if the difference is negative, we make it positive by multiplying with -1
            if(diff < 0){
                diff = -diff;
            }
            
            // store the absolute difference 
            newArr[pos] = diff;
            pos++;
        }
        
        // Step 4: handle circular case (last and first element)
        int lastDiff = arr[n - 1] - arr[0];
        
        // convert to absolute -> if the difference is negative, we make it positive by multiplying with -1
        if(lastDiff < 0){
            lastDiff = -lastDiff;
        }
        
        // store circular difference
        newArr[pos] = lastDiff;
        
        // Step 5: initialize result with first value
        int result = newArr[0];
        
        // find minimum difference
        for(int j = 1; j < n; j++){
            if(newArr[j] < result){
                result = newArr[j];
            }
        }
        
        // return final answer
        return result;
    }
}

class Program {
    public static void Main(string[] args) {
        
        // sample input
        int n = 7;
        int[] arr = {8, -8, 9, -9, 10, -11, 12};
        
        Solution obj = new Solution();
        
        // function call
        int result = obj.minAdjDiff(arr, n);
        
        // print output
        Console.WriteLine("Minimum Adjacent Difference: " + result);
    }
}

/*
OUTPUT:
Minimum Adjacent Difference: 1
*/