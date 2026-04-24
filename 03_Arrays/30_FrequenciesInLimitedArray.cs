
/*

Frequencies in Limited Array: Easy : below is 

A) Optimized Approach: Using Frequency Array

Input: arr[] = [2, 1, 1]
Output: [2, 1, 0]
Explanation: The count of 1 is 2, count of 2 is 1 and count of 3 is 0. Hence the output is [2, 1, 0].


==================== ✅ APPROACH ====================

We need to count frequency of elements from 1 to N (array size).

👉 Idea:
Instead of checking each number again and again (O(n²)),
we use a frequency array to store counts in one pass.

Steps:
1. Create a frequency array `freq` of size (n + 1) -> wherein we will store counts of numbers from 1 to n.
   → Index represents the number
   → Value represents its count

2. Traverse the given array:
   → For each element arr[i], increase freq[arr[i]]

3. Traverse freq from 1 to n:
   → Store values in result list

----------------------------------------------------

🧪 Example:

Input: arr = [2, 1, 1]
n = 3

Step 1:
freq = [0,0,0,0]

Step 2:

freq[arr[i]]++ for each element:

Freq[arr[0]] => arr[0] = 2 → freq[2]++ → [0,0,1,0] => increasing count of index pos 2 i.e. freq[2] = 1
Freq[arr[1]] => arr[1] = 1 → freq[1]++ → [0,1,1,0] => increasing count of index pos 1 i.e. freq[1] = 1
Freq[arr[2]] => arr[2] = 1 → freq[1]++ → [0,2,1,0] => increasing count of index pos 1 again i.e. freq[1] = 2

Step 3:
result = [freq[1], freq[2], freq[3]]
        = [2, 1, 0]

====================================================

⏱️ Time Complexity: O(n)
→ Single pass to count + single pass to build result

📦 Space Complexity: O(n)
→ Extra frequency array used

====================================================
*/

using System;
using System.Collections.Generic;
class Solution {
    public List<int> frequencyCount(int[] arr) {
        
        int n = arr.Length;
        
        // Step 1: Create frequency array
        int[] freq = new int[n + 1];
        
        // Step 2: Count frequencies
        for(int i = 0; i < n; i++){
            if(arr[i] >= 1 && arr[i] <= n){
                freq[arr[i]]++; 
            }
        }
        
        // Step 3: Store result
        List<int> result = new List<int>();
        
        for(int i = 1; i <= n; i++){
            result.Add(freq[i]);
        }
        
        return result;
    }
}

class Program {
    public static void Main(string[] args) {
        
        int[] arr = {2, 1, 1};
        
        Solution sol = new Solution();
        List<int> result = sol.frequencyCount(arr);
        
        Console.WriteLine("Frequency Count:");
        foreach(int num in result){
            Console.Write(num + " ");
        }
    }
}
/*
OUTPUT:
Frequency Count:
2 1 0
*/

//-------------------------------------------------------------------------------------

/*
B) Brute Force Approach: Nested Loops

using System;
using System.Collections.Generic;

/*
==================== ✅ APPROACH ====================

We need to count frequency of numbers from 1 to N (array size).

👉 Idea (Brute Force):
For every number from 1 to N:
    - Traverse the whole array
    - Count how many times that number appears

----------------------------------------------------

🧪 Example:

Input: arr = [2, 1, 1]
n = 3

i = 1 → count = 2
i = 2 → count = 1
i = 3 → count = 0

Output: [2, 1, 0]

----------------------------------------------------

⏱️ Time Complexity: O(n²)
→ Outer loop runs N times
→ Inner loop runs N times

📦 Space Complexity: O(1)
→ Only result list (not counted as extra space usually)

⚠️ Note:
This approach may give TLE for large inputs.
Optimized solution is O(n) using frequency array.

====================================================
*/
/*
class Solution {
    public List<int> frequencyCount(int[] arr) {
        
        List<int> list = new List<int>();
        int n = arr.Length;
        
        // Loop from 1 to N -> checking frequency of each number
        for(int i = 1; i <= n; i++){
            int count = 0;
            
            // Count occurrences of i in array
            for(int j = 0; j < n; j++){
                if(arr[j] == i){
                    count++;
                }
            }
            
            // Store result
            list.Add(count);
        }
        
        return list;
    }
}

class Program {
    public static void Main(string[] args) {
        
        // Example input
        int[] arr = {2, 1, 1};
        
        Solution sol = new Solution();
        List<int> result = sol.frequencyCount(arr);
        
        Console.WriteLine("Frequency Count:");
        
        // Print result
        foreach(int num in result){
            Console.Write(num + " ");
        }
    }
}
*/
/*
==================== ✅ OUTPUT ====================

Frequency Count:
2 1 0

=================================================
*/

