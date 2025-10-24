/*
Exactly 3 Divisors: 
Given a positive integer value n. The task is to find how many numbers less than or equal to n have numbers of divisors exactly 3.

E.g. 1:
Input: n = 6
Output: 1
Explanation: The only number less than 6 with 3 divisors is 4 which has 1, 2 and 4 as divisors.

E.g. 2:
Input: n = 10
Output: 2
Explanation: 4 and 9 have 3 divisors. 
    1. 4 is divisible by 1, 2, 4. 
    2. 9 is dibisible by 1, 3, 9

so we got 4 and 9 numbers which have exactly 3 divisors so as we got 2 number s our output will be 2.

*/

//----------------------------------------------------------------------------

//1. Naive Solution

/*
Approach for naive solution:
    1. Take input n and initialize finalCount = 0.
    2. Loop through numbers from n-1 down to 1.
        - For each number i, start count = 0.
        - Run another loop from i down to 1.
        - If i is divisible by j, increment count.
    3. After the inner loop, check if count == 3.
        - If yes, increase finalCount.
    4. At the end, print finalCount (total numbers with exactly 3 divisors).


*/
/*
using System;

public class Exactly3Divisors
{
    public static void Main(string[] args)
    {
        int n = 10;
        int finalCount = 0;
        for (int i = n - 1; i >= 1; i--)
        {
            int count = 0;

//started loop with i because the given number will be divisible by its lower number not more than ggiven number
            for (int j = i; j >= 1; j--)
            {
                if (i % j == 0)
                {
                    count++;
                }
            }

            if (count == 3)
            {
               // System.Console.WriteLine("the number " + i + " is divisble by  total " + count + " numbers");
                finalCount++;
              
            }


        }
        System.Console.WriteLine("Final Count is: " + finalCount);
    }
}
*/
/*
OUTPUT:
n=10
Final Count is: 2

*/


//----------------------------------------------------------------------------

//2. Optimize solution
/*
Approach:
A number has exactly 3 divisors only if it is the square of a prime number.
Example: 4 = 2² → divisors {1, 2, 4}
Example: 9 = 3² → divisors {1, 3, 9}

So, we just need to:
Find all prime numbers up to √n.
Count how many of their squares are ≤ n.
The function IsPrime checks if a number is prime.
For every prime p with p² ≤ n, increase the count.
Return the count as the final answer.
*/

using System;

public class Solution
{
    // Function to count numbers with exactly 3 divisors up to n
    public int exactly3Divisors(int n)
    {
        int count = 0; // this will store our final answer

        // We only need to check prime numbers up to √n
        for (int i = 2; i * i <= n; i++)
        {
            // If i is prime and i^2 is <= n,
            // then i^2 has exactly 3 divisors (1, i, i^2)
            if (IsPrime(i))
            {
                if (i * i <= n)
                {
                    count++; // increase count
                }
            }
        }

        return count; // return the total count
    }

    // Function to check if a number is prime
    private bool IsPrime(int num)
    {
        if (num < 2) return false; // numbers < 2 are not prime

        // check divisibility from 2 up to √num
        for (int i = 2; i * i <= num; i++)
        {
            if (num % i == 0) return false; // if divisible, not prime
        }
        return true; // otherwise prime
    }

    // Main method: program starts here
    public static void Main(string[] args)
    {
        Solution sol = new Solution();

        Console.WriteLine("Enter a number: ");
        int n = Convert.ToInt32(Console.ReadLine()); // take input

        // find how many numbers <= n have exactly 3 divisors
        int result = sol.exactly3Divisors(n);

        // print the answer
        Console.WriteLine($"Count of numbers ≤ {n} with exactly 3 divisors: {result}");
    }
}
/*
OUTPUT
Enter a number: 
10
Count of numbers ? 10 with exactly 3 divisors: 2
*/