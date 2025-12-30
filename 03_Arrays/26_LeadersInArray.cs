
/*
Leader in Array:
A leader is an element which is greater than all the elements to its right side.

E.g: 
Input: arr = [16, 17, 4, 3, 5, 2]
Output: [17, 5, 2]
Explanation: Note that there is nothing greater on the right side of 17, 5 and, 2.

//Aproach to resolve:
    1. Loop through each element of the array.
    2. For each element, check all elements to its right.
    3. If no element to the right is greater, it's a leader.
    4. Store the leader in a result array.
    5. Print all stored leaders.
    6. Last element is always a leader because there are no elements to its right.

*/


using System;

public class LeaderInArray
{
    public static void Main(string[] args)
    {
        // Initialize the input array
        int[] arr = {16, 17, 4, 3, 5, 2};

        // Get the length of the array
        int n = arr.Length;

        // Create a new array to store leader elements (max size = n)
        int[] newArr = new int[n];

        // 'res' keeps track of the number of leaders found (also index for newArr)
        int res = 0;

        // Outer loop: go through each element in the array
        for (int i = 0; i < n; i++)
        {
            bool isLeader = true; // Assume current element is a leader

            // Inner loop: compare current element with all elements to its right
            for (int j = i + 1; j < n; j++)
            {
                // If any element on the right is greater, current is not a leader
                if (arr[i] < arr[j])
                {
                    isLeader = false;
                    break; // No need to check further
                }
            }

            // If element is a leader, store it in newArr
            if (isLeader == true)
            {
                newArr[res] = arr[i];
                res++; //keep track of the number of leaders found
            }
        }

        // Print the leader elements
        System.Console.WriteLine("Following are the leaders in the array: ");
        for (int p = 0; p < res; p++) //p<res to print only the leaders found
        // Print the leaders stored in newArr
        {
            System.Console.WriteLine(newArr[p]);
        }
    }
}
/*
OUTPUT:
Following are the leaders in the array: 
17
5
2
*/