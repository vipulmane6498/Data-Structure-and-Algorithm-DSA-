// ------------------------------------------------------------
//-- Maximum Appearing Element in Given Ranges
// level medium: array manipulation, prefix sum
//E.g. Left[] = {1, 2, 4}
//     Right[] = {4, 5, 7}
// Output: 4
// Explanation: The element 4 appears in all three ranges:
// [1,4], [2,5], and [4,7].
//[1,4] -> 1,2,3,4
//[2,5] -> 2,3,4,5
//[4,7] -> 4,5,6,7
//Explanation: The element 4 appears in all three ranges:

// Approach:
// This program finds the element that appears the most 
// in given ranges of Left[] and Right[].
//
// Steps:
// 1. Find the maximum value in Right[] (this defines the size of the freq[] array,
//    which will be used to mark increments and decrements based on the Left[] and Right[] ranges).
// 2. Create a frequency array (freq[]) to record the contribution of each range.
// 3. For each range [Left[i], Right[i]], increment freq[Left[i]] by 1
//    and decrement freq[Right[i] + 1] by 1.
//    (This technique is known as the "Prefix Sum" or "Difference Array" method.)
// 4. Compute the prefix sum on freq[] to get the actual frequency of each element.
// 5. Find the index with the highest frequency — this represents the element
//    that appears in the maximum number of ranges.

// ------------------------------------------------------------

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] Left = {1, 2, 4};
        int[] Right = {4, 5, 7};
        int n = Left.Length;
        
        // Step 1: Find maximum value in Right[] (to know how far freq[] should go)
        int maxVal = 0;
        for (int i = 0; i < n; i++)
            if (Right[i] > maxVal)
            {
                maxVal = Right[i];
                
            }//from Right={4,5,7}=> maxVal=7

        // Step 2: Create frequency array with enough size (+2 to handle Right[i] + 1 safely)
        int[] freq = new int[maxVal + 2];
        //freq[] initially = {0,0,0,0,0,0,0,0,0}
        
        // Step 3: For each range, mark start and end+1 in freq[]
        for (int i = 0; i < n; i++)
        {
            freq[Left[i]]++;          // Increment at start
            freq[Right[i] + 1]--;     // Decrement just after end
        }//freq[] becomes → {0,1,1,0,1,-1,-1,0,-1}

        // Step 4: Compute prefix sum to get actual frequencies
        int res = 0;
        for (int i = 1; i <= maxVal; i++)
        {
            freq[i] = freq[i] + freq[i - 1];   // Build prefix sum
            //eventually prefix sum of freq becomes= {0, 1, 2, 2, 3, 2, 1, 1, 0}

            if (freq[i] > freq[res])  // Track element with max frequency
                res = i;
                 //eventually res becomes= 4 as at 4rth index of prefix sum freq[] we have maximum value 3

        }

        Console.WriteLine("Maximum appearing element: " + res);//OUTPUT → Maximum appearing element: 4
    }
}


// ------------------------------------------------------------
// DRY RUN:
// Left[] = {1, 2, 4}
// Right[] = {4, 5, 7}
//
// Step 1: maxVal = 7
// freq[] initially = {0,0,0,0,0,0,0,0,0}
//
// Step 2 & 3: After marking
//   For [1,4] → freq[1]++, freq[5]--
//   For [2,5] → freq[2]++, freq[6]--
//   For [4,7] → freq[4]++, freq[8]--
// freq[] becomes → {0,1,1,0,1,-1,-1,0,-1}
//
// Step 4: Prefix Sum computation
//   i=1 → freq[1]=1
//   i=2 → freq[2]=1+1=2
//   i=3 → freq[3]=2+0=2
//   i=4 → freq[4]=2+1=3   <-- highest so far
//   i=5 → freq[5]=3+(-1)=2
//   i=6 → freq[6]=2+(-1)=1
//   i=7 → freq[7]=1+0=1
// //eventually prefix sum of freq becomes= {0, 1, 2, 2, 3, 2, 1, 1, 0}
//
// Maximum frequency = 3 at element = 4
//
// OUTPUT → Maximum appearing element: 4
// ------------------------------------------------------------
