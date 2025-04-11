// Remove Element
//from Leetcode

// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.

// Input: nums = [3,2,2,3], val = 3
// Output: 2, nums = [2,2,_,_]
// hint : return the last index of number of actual element.


public class Solution {
    public int RemoveElement(int[] nums, int val) {

        ///res is the pointer to track unique elements in the same array.
        int res=0;
        for(int i=0; i<nums.Length; i++){
            //if the current element is not equal to val, then add it to the result array.
            //res is the pointer to track unique elements in the same array.
            //nums[res] = nums[i] will overwrite the duplicates in the same array.
            if(nums[i] != val){
                nums[res] = nums[i];
                res++;
            }
        }
        return res;
    }

    public static void Main(string[] args){
        int[] nums = {3,2,2,3};
        int val = 3;
        Solution sol = new Solution();
    
        //result will return the return the last index of number of actual element
        int result = sol.RemoveElement(nums, val);

        //return the number of elements not equal to val
        Console.WriteLine("Number of elements not equal to " + val + ": " + result);

        //return the actual elements in the array
        Console.WriteLine("Modified array: ");
        for (int i = 0; i < result; i++) {
            Console.Write(nums[i] + " ");
        }
    }
}