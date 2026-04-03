
/* Reverse Array in Groups:
means: Reverse the array in groups of size k.

Brief SOlution: We have give a k =3 means we have to reverse the first 3 elements and then next 3 elements and so on. 
If remaining elements are less than k, still reverse them.

E.g. arr = [1, 2, 3, 4, 5, 7, 8, 9], k = 3
Output: [3, 2, 1, 5, 4, 7, 8, 9]
Explanation:
- First group (1, 2, 3) is reversed to (3, 2, 1)
- Second group (4, 5, 7) is reversed to (7, 5, 4)
- Third group (8, 9) is reversed to (9, 8)
================== ✅ APPROACH (EASY) ==================

Goal:
Reverse the array in groups of size k.

Steps:
1. Start from index 0.
2. Take a group of size k:
   → from index i to i + k - 1
3. Reverse only that group.
4. Move to next group:
   → i = i + k
5. Repeat until end of array.

Important:
- If remaining elements are less than k,
  still reverse them.

------------------ ⏱️ TIME COMPLEXITY ------------------
O(n)
→ Each element is visited once while reversing

------------------ 💾 SPACE COMPLEXITY -----------------
O(1)
→ In-place swapping, no extra space used

========================================================
*/
using System;
using System.Collections.Generic;

class Solution {
    public void reverseInGroups(List<int> arr, int k) {
      
        // Traverse the array in steps of k
        for(int i = 0; i < arr.Count; i = i + k){

                    /*
                    --------- i ITERATION FLOW (k = 3) ---------
                    Iteration 1: i = 0
                    Next i = i + k → 0 + 3 = 3

                    Iteration 2: i = 3
                    Next i = i + k → 3 + 3 = 6

                    Iteration 3: i = 6
                    Next i = i + k → 6 + 3 = 9
                    ------------------------------------------------
                    */


            int left = i;

            // Calculate right boundary of current group
            int right = Math.Min(i + k - 1, arr.Count - 1);
                    /*
                    --------- right CALCULATION FLOW (k = 3, n = 5) ---------
                    Formula:
                    right = Math.Min(i + k - 1, arr.Count - 1)

                    Iteration 1:
                    i = 0
                    i + k - 1 = 0 + 3 - 1 = 2
                    arr.Count - 1 = 5 - 1 = 4
                    right = Min(2, 4) = 2

                    Iteration 2:
                    i = 3
                    i + k - 1 = 3 + 3 - 1 = 5
                    arr.Count - 1 = 4
                    right = Min(5, 4) = 4
                    ---------------------------------------------------------
                    */

            // Reverse elements within this group
            while(left < right){

                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;

                left++;
                right--;
                    /*
                        --------- 🔍 DRY RUN (Example) ---------
                        arr = [1, 2, 3, 4, 5], k = 3

                        First group → i = 0 → left = 0, right = 2

                        Step 1:
                        left = 0, right = 2
                        Swap arr[0] and arr[2]
                        → [3, 2, 1, 4, 5]

                        Move pointers:
                        left++ → 1
                        right-- → 1

                        Now left == right → loop stops

                        ----------------------------------------

                        Second group → i = 3 → left = 3, right = 4

                        Step 1:
                        left = 3, right = 4
                        Swap arr[3] and arr[4]
                        → [3, 2, 1, 5, 4]

                        Move pointers:
                        left++ → 4
                        right-- → 3

                        Now left > right → loop stops
                        ----------------------------------------
                        */
            }
        }
    }
}

class Program {
    public static void Main() {

        Solution obj = new Solution();

        List<int> arr = new List<int> { 1, 2, 3, 4, 5 };
        int k = 3;

        obj.reverseInGroups(arr, k);

        Console.WriteLine("Output: [" + string.Join(", ", arr) + "]");
    }
}

/*
================== ✅ OUTPUT ==================

Output: [3, 2, 1, 5, 4]

===============================================
*/






//------------------------------------------------------------------------------------


/*

Solution 2
Problem: Reverse Array in group
================== ❌ YOUR APPROACH ==================

1. If array size is smaller than k:
   → Reverse the whole array.

2. Otherwise:
   → Step 1: Reverse first k elements (0 → k-1)
   → Step 2: Reverse remaining elements (k → n-1)

⚠️ NOTE:
This approach works only when there are 2 groups:
- First k elements
- Remaining elements

It does NOT work for multiple groups (interview limitation)

=====================================================
*/
/*
using System;
using System.Collections.Generic;


class Solution {
    public void reverseInGroups(List<int> arr, int k) {

        // ================== STEP 1 ==================
        // If array size is smaller than k → reverse whole array
        if(arr.Count < k){
            int low = 0;
            int high = arr.Count - 1;

            while(low < high){
                // Swap elements
                int temp = arr[low];
                arr[low] = arr[high];
                arr[high] = temp;

                low++;
                high--;
            }

            return; // stop further execution
        }

        // ================== STEP 2 ==================
        // Reverse first k elements (0 → k-1)
        int m = 0;
        int n = k - 1;

        while(m < n){
            // Swap elements
            int temp = arr[m];
            arr[m] = arr[n];
            arr[n] = temp;

            m++;
            n--;
        }

        // ================== STEP 3 ==================
        // Reverse remaining elements (k → end)
        int q = k;
        int final = arr.Count - 1;

        while(q < final){
            // Swap elements
            int temp = arr[q];
            arr[q] = arr[final];
            arr[final] = temp;

            q++;
            final--;
        }
    }
}

class Program {
    public static void Main() {
        // ================== INPUT ==================
        List<int> arr = new List<int> { 5, 6, 8, 9 };
        int k = 5;

        Solution obj = new Solution();
        obj.reverseInGroups(arr, k);

        // ================== OUTPUT ==================
        Console.WriteLine("Output: [" + string.Join(", ", arr) + "]");
    }
}
*/
/*
================== OUTPUT ==================

Input = [1, 2, 3, 4, 5]; k = 3
Output: [3, 2, 1, 5, 4]

Input = [5, 6, 8, 9]; k = 5
Output: [9, 8, 6, 5]

===========================================
*/