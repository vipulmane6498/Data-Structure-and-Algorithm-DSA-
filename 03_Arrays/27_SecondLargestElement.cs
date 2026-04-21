/*
Second Largest Element in an Array: Easy

Input: arr[] = [12, 35, 1, 10, 34, 1]
Output: 34
Explanation: The largest element of the array is 35 and the second largest element is 34.

================== APPROACH ==================
1. Initialize:
   - FirstLargest index = 0
   - Second Largest index = -1 (means not found)

2. Traverse the array from index 1:
   a) If current element > first largest:
      - Update second largest = first largest
      - Update first largest = current index

   b) Else if current element != first largest:
      - Check if it can be second largest:
        i) If second largest not assigned OR
        ii) current element > current second largest
      - Update second largest

3. If second largest is still -1:
   - Return -1 (no second largest exists)

4. Else return value at second largest index

Time Complexity  : O(n)
Space Complexity : O(1)
=============================================
*/
class SecondLargestElement
{
    public int GetSecondLargest(int[] arr)
    {


        int SecLargest = -1;     // Index of second largest element
        int FirstLargest = 0;    // Index of largest element

        // Traverse array starting from index 1
        for (int i = 1; i < arr.Length; i++)
        {

            // If current element is greater than the largest
            if (arr[i] > arr[FirstLargest])
            {
                SecLargest = FirstLargest; // Update second largest
                FirstLargest = i;          // Update largest
            }

            // If current element is not equal to largest
            else if (arr[i] != arr[FirstLargest])
            {

                // Check if it can be second largest
                if (SecLargest == -1 || arr[i] > arr[SecLargest])
                {
                    SecLargest = i;
                }
            }
        }

        // If no second largest found
        if (SecLargest == -1)
        {
            return -1;
        }

        // Return second largest value
        return arr[SecLargest];
    }

    public static void Main()
    {
        SecondLargestElement obj = new SecondLargestElement();

        int[] arr = { 12, 35, 1, 10, 34, 1 };



        // Get second largest element
        int result = obj.GetSecondLargest(arr);

        if (result != -1)
        {
            System.Console.WriteLine("Second Largest Element: " + result);
        }
        else
        {
            System.Console.WriteLine("No second largest element exists.");
        }
    }
}
/*
OUTPUT:
Second Largest Element: 34
*/
