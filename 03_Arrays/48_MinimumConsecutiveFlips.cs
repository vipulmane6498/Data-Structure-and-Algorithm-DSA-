 // ---------------------------------------------
        // 🧠 APPROACH: Minimum Consecutive Flips
        // ---------------------------------------------
        // 1️⃣ The array only contains 0s and 1s.
        // 2️⃣ We can divide the array into "groups" of consecutive same numbers.
        //     Example: {1, 1, 0, 0, 0, 1, 0, 0, 1, 1}
        //     Groups: [1,1] [0,0,0] [1] [0,0] [1,1]
        //
        // 3️⃣ We want to make all numbers same (either all 0s or all 1s)
        //     by flipping the *minimum number* of consecutive groups.
        //
        // 4️⃣ Fact: The number of 0-groups and 1-groups
        //     are either equal or differ by 1.
        //
        // 5️⃣ So, the best strategy:
        //      Always flip the second group and all groups of the same type as that second group.
        //      This gives the minimum flips.So we can always flip the *second group*
        //     and all groups of the same type (0 or 1) as that second group.
        //
        // 6️⃣ We'll detect where each group starts and ends
        //     by checking when the value changes from 0 → 1 or 1 → 0.
        //
        // ---------------------------------------------
        // ⚙️ LOGIC IN CODE:
        // ---------------------------------------------
        // - Traverse array once (O(n) time).
        // - Whenever arr[i] != arr[i-1], a new group starts.
        // - If this new group is not same as the first group → "Start flipping".
        // - When we encounter the same as the first group again → "Stop flipping".
        // - Handle the last group if needed.
        // ---------------------------------------------


using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
       

        int[] arr = {1, 1, 0, 0, 0, 1, 0, 0, 1, 1}; // given binary array
        int n = arr.Length; // length of array

        // Traverse from 2nd element (i = 1) to last
        for (int i = 1; i < n; i++)
        {
            // Check if there is a change from previous element
            if (arr[i] != arr[i - 1])
            {
                // ✅ When a new group starts
                // Example: arr[i-1]=1 and arr[i]=0 OR arr[i-1]=0 and arr[i]=1

                // If this new group is different from the first element's group,
                // it means this is the group we need to flip.
                if (arr[i] != arr[0])
                {
                    // Print the starting index of the group to flip
                    Console.Write("From " + i + " To ");
                }
                else
                {
                    // If it's same as the first element's group,
                    // it means the previous flip group just ended
                    // so print the ending index.
                    Console.WriteLine(i - 1);
                }
            }
        }

        // If the last group ends with a different number than the first group,
        // then we haven’t yet printed its end — so print its ending index now.
        if (arr[n - 1] != arr[0])
            Console.WriteLine(n - 1);

        // ---------------------------------------------
        // 🧩 Example Walkthrough:
        // Input: {1, 1, 0, 0, 0, 1, 0, 0, 1, 1}
        //
        // Groups: [1,1] [0,0,0] [1] [0,0] [1,1]
        //
        // Output:
        // From 2 To 4
        // From 6 To 7
        //
        // Means: Flip indices 2–4 and 6–7
        // After flipping, all elements become 1.
        // ---------------------------------------------
    }
}
     // Output:
        // From 2 To 4
        // From 6 To 7