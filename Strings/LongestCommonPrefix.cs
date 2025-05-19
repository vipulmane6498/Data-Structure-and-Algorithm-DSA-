    // Problem: Longest Common Prefix - Easy

    // Approach:
    // If the array is empty or null, return an empty string.
    // Sort the array of strings lexicographically(Alphabetically).
    // After sorting, the first and last strings will be the most different.
    // Compare the first and last strings character by character.
    // The common prefix of these two is the longest common prefix for the entire array.

    using System;

    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            string[] strs = { "flower", "flow", "flight" };

            // Call the function to find the longest common prefix
            string prefix = LongestCommonPrefix(strs);

            // Print the result
            Console.WriteLine("Longest Common Prefix: " + prefix);
        }

        static string LongestCommonPrefix(string[] strs)
        {
            // If the array is null or empty, return an empty string
            if (strs == null || strs.Length == 0) return "";

            // Sort the array of strings alphabetically (lexicographically)
            Array.Sort(strs); //after sorting: ["flight", "flower", "flow"]

            // After sorting, compare only the first and last string in the array
            string first = strs[0];
            string last = strs[strs.Length - 1];
            string result = "";

            // Loop through each character of the shorter string between first and last
            for (int i = 0; i < Math.Min(first.Length, last.Length); i++)
            {
                // If characters don't match, break the loop
                if (first[i] != last[i])
                    break;

                // If they match, add to result (common prefix so far)
                result = result + first[i];
            }

            // Return the longest common prefix found
            return result;
        }
    }
