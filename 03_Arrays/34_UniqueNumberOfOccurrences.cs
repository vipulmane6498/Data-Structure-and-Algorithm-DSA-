
/*

Unique Number of Occurrences:

we are taking interger array count and if the element found in given array we increament the index of that number in count array
e.g. if we found 2 in given array we increament count[2] by 1
-> if count[arr[1]]++ => arr[1]=2 => count[2]++ => count[2]=1 so at index 2 of count array we have 1
-> if we found -2 in given array we increament count[1000+(-arr[i])] by 1

Approach

Frequency Count of Each Element

We create an integer array count[2010] to store how many times each number appears in the input array.

Why 2010?

Because numbers can be negative and positive.

For positives → use their value as index directly.

For negatives → shift them by 1000 so they don’t clash with positive indexes.
Example: -2 → stored at index 1000 + 2 = 1002.

Count Occurrences

Traverse the input array.

For each number:

    If it is positive → count[arr[i]]++

    If it is negative → count[1000 + (-arr[i])]++

Check for Uniqueness of Occurrences

Now, we check whether all non-zero frequencies in count are unique.

Nested loops are used:

Compare count[i] with all count[j] where j > i.

If two counts are the same (and not zero), return false.

Return the Result

If no duplicates are found in frequency counts → return true.
*/
using System;

public class Solution
{
    public bool UniqueOccurrences(int[] arr)
    {
        int[] count = new int[2010];

        for (int i = 0; i < arr.Length; i++)
        {
            // for +ve number
            if (arr[i] >= 0)
            {
                count[arr[i]]++;
            }
            // -ve number
            else
            {
                int NegativeNum = 1000 + (arr[i] * -1);
                count[NegativeNum]++;
            }
        }

        for (int i = 0; i < count.Length; i++)
        {
            for (int j = i + 1; j < count.Length; j++)
            {
                if (count[i] != 0 && count[i] == count[j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    // Main method to test
    public static void Main(string[] args)
    {
        Solution sol = new Solution();

        int[] arr1 = { 1, 2, 2, 1, 1, 3 };
        Console.WriteLine("Example 1: " + sol.UniqueOccurrences(arr1)); // Output: True

        int[] arr2 = { 1, 2 };
        Console.WriteLine("Example 2: " + sol.UniqueOccurrences(arr2)); // Output: False

        int[] arr3 = { -1, -2, -2, -1, -1, -3 };
        Console.WriteLine("Example 3: " + sol.UniqueOccurrences(arr3)); // Output: True
    }
}
/*

OTUPUT:
I added 3 test cases in Main:

{1,2,2,1,1,3} → should return True

{1,2} → should return False

{-1,-2,-2,-1,-1,-3} → should return True (works for negatives too)
*/