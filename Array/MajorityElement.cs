
//Majority ELement
// The majority element is the element that appears more than ⌊n / 2⌋ times. You may assume that the majority element always exists in the array.

// n is the length of the array.
// Example 1:

// Input: nums = [3,2,3]
// Output: 3

// Example 2:

// Input: nums = [2,2,1,1,1,2,2]
// Output: 2


// understand question:
// Questions says:  if the size of the array is 3 so n=3 then n/2 = 3/2 = 1.5 so the majority element is the element that appears more than 1.5 or 1 times in the array.
// in this example Input: nums = [3,2,3]
// its length is 3 and 3/2 = 1.5 so the majority element is the element that appears more than 1.5 or 1 times in the array.
// // So the majority element is 3 because it appears 2 times in the array.    
// so return that element 3


//Appprach:
// Boyer-Moore Voting Algorithm – Steps
// 1. Initialize count = 0 and candidate = 0

// 2. Loop through each number num in the array:
// If count == 0, set candidate = num
// If num == candidate, increment count by 1
// Else, decrement count by 1

// 3. After the loop ends, return candidate as the majority element.



using System;

public class Solution
{
    public int MajorityElement(int[] nums)
    {

        int count = 0;
        int cand = 0;

        // Boyer-Moore Voting Algorithm
        // This algorithm is used to find the majority element in an array.
        for (int i = 0; i < nums.Length; i++)
        {

            //[3,2,3]
            // If count is 0, set the candidate to the current element.
            if (count == 0)
            {
                cand = nums[i];
            }
            // If the candidate is the same as the current element, increment count.
            if (cand == nums[i])
            {
                count++;
            }
            // If the candidate is different, decrement count.
            // If count becomes 0, we need to find a new candidate.
            else
            {
                count--;
            }

        }
        return cand;

    }
}

// Main method to test the MajorityElement function
// This method is not part of the Solution class but is included for testing purposes.

public class Program
{
    public static void Main(string[] args)
    {
        // Creating an instance of the Solution class
        Solution solution = new Solution();

        // Input array
        int[] nums = { 2, 2, 1, 1, 1, 2, 2 };

        // Finding the majority element using the MajorityElement method
        int result = solution.MajorityElement(nums);

        // Output the result
        Console.WriteLine("Majority Element: " + result);  // Output: 2
    }
}
