/*
    Problem: Check if the array sorted and rotated - Medium but extreamly easy solution
Solution: 1 

Solution in breif: 
1. 1st check: check if the current element is greater than next element if yes increase count arr[i] > arr[(i + 1) % n]. (i+1)%n handles circular comparison (last → first)  
2. 2nd check: if the count is 1 AND 1st element of the array should be larger than the last element of the array means true . it is sorted and rotated Or otherwise not.

================== ✅ APPROACH ==================

1. A sorted & rotated array has ONLY ONE "drop point"
→ A drop means: arr[i] > arr[i+1]

Example:
Array: [4, 5, 1, 2, 3]

Check:
4 < 5  ✅
5 > 1  🔻 DROP (only one drop)
1 < 2  ✅
2 < 3  ✅

👉 Total drops = 1 ✅ → VALID

2. Traverse the array and count number of such drops

3. Use circular check:
→ Compare last element with first using (i+1) % n

4. Conditions to be TRUE:
✅ count == 1 → exactly one rotation point  
✅ arr[0] > arr[n-1] → ensures it is rotated (not just sorted)

5. If both conditions satisfied → return true
else → false


/*
================== ⏱️ COMPLEXITY ==================

Time Complexity:
→ O(n)
Reason:
- Single loop runs n times

Space Complexity:
→ O(1)
Reason:
- No extra space used (only variables)

==================================================
*/


class CheckIfArrayIsSortedAndRotated
{
    public bool IsSortedRotated(int[] arr)
    {
        int count = 0; // counts number of "drop points"
        int n = arr.Length;

        // ✅ Step 1: Count number of drop points
        for (int i = 0; i < n; i++)
        {
            //check if the current element is greater than next element if yes increase count
            // (i+1)%n handles circular comparison (last → first)
            if (arr[i] > arr[(i + 1) % n])
            {
                count++; // found a drop
            }

            /*
            🔁 DRY RUN:

            Example: arr = [4,5,1,2,3]

            i=0 → 4 < 5 → no drop
            i=1 → 5 > 1 → DROP (count = 1)
            i=2 → 1 < 2 → no drop
            i=3 → 2 < 3 → no drop
            i=4 → 3 < 4 (circular check) → no drop

            Final count = 1
            */
        }

        // ✅ Step 2: Final condition check
        // count must be exactly 1 AND array must be rotated(means if the 1st element of the array should be larger than the last element fo the array in our case 4>3 => true)
        bool result = (count == 1 && arr[0] > arr[n - 1]);

        /*
        🔁 FINAL DRY RUN CHECK:

        arr = [4,5,1,2,3]

        arr[0] = 4, arr[n-1] = 3
        4 > 3 ✅ → confirms rotation

        OUTPUT → true (sorted & rotated)
        */

        return result;
    }
    public static void Main(string[] args)
    {
        int[] arr = { 4, 5, 1, 2, 3 };

        Solution sol = new Solution();

        bool result = sol.IsSortedRotated(arr);

        if (result)
        {
            Console.WriteLine("Yes, sorted and rotated");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
/*
OTUPUT:
Yes, sorted and rotated
*/

//---------------------------------------------------------------------


/*
Solution 2 (Brute Force - Not Optimal) but easy to understand:

Problem: Check if an array is sorted and rotated - Easy

Solution in brief: Sort the array and then rotate it one by one and compare with original array. If any rotation matches original array then it is sorted and rotated otherwise not.

================== ✅ APPROACH ==================

1. Take the given array (example: [4,5,1,2,3])

2. Copy it into another array (oldArr) 
    → This helps us preserve the original array

3. Sort the original array
    → After sorting: [1,2,3,4,5]

4. Rotate the sorted array one by one (right rotation) 
    → After 1st rotation: [5,1,2,3,4]
    → After 2nd rotation: [4,5,1,2,3] (matches oldArr)
    → If we find a match at any point → "Sorted and Rotated"
    → If no match after all rotations → "Not Sorted and Rotated"

5. After each rotation, compare it with oldArr

6. If any rotation matches oldArr
    → Then array is "Sorted and Rotated"

7. If no match found after all rotations
    → Then NOT sorted & rotated


    Time Complexity: O(n^2) → due to sorting (O(n log n)) and rotations (O(n^2) in worst case)
    Space Complexity: O(n) → due to copying original array into oldArr

=================================================
*/

/*
using System;

public class CheckIfArrayIsSortedAndRotated
{
    public static void Main(string[] args)
    {

        int[] arr = {4,5,1,2,3};
        
        int n = arr.Length;
        
        // ✅ Step 1: Copy original array
        int[] oldArr = new int[n];
        for(int i = 0; i < n; i++){
            oldArr[i] = arr[i]; 
        }
        // oldArr = [4,5,1,2,3]

        // ✅ Step 2: Sort array using Bubble Sort
        for(int i = 0; i < n - 1; i++){
            for(int j = 0; j < n - 1 - i; j++){
                if(arr[j] > arr[j + 1]){
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                } 
            }
        }

        // After sorting:
        // arr = [1,2,3,4,5]

        bool isSame = false;

        // ✅ Step 3: Try all rotations
        for(int i = 0; i < n; i++)
        {
            

            // Step 3.1: store last element
            int last = arr[n - 1];

            // Step 3.2: shift elements to right
            for(int j = n - 1; j > 0; j--){
                arr[j] = arr[j - 1];
            }

            // Step 3.3: put last element at first position
            arr[0] = last;

            // ✅ Step 4: Compare with original array


            bool match = true; //intially consider match is true

            for(int k = 0; k < n; k++){
                if(arr[k] != oldArr[k]){
                    match = false; //match became false if any element is not same
                    break;
                }
            }

            // If match found → means isSame is also true hence break look and stop loop
            if(match==true){
                isSame = true;
                break;
            }
        }

        // ✅ Step 5: Final Result
        if(isSame==true){
            Console.WriteLine("Yes, sorted and rotated");
        }
        else{
            Console.WriteLine("No");
        }
    }
}
*/
/*
OTUPUT:
Yes, sorted and rotated
*/  