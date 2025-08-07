/*
M Shape Star Pattern:

Approach:
1. Get the number of rows (height of the M) from the user.
2. Outer loop iterates through each row.
    2.1 the inner loop print the stars
    2.2 Conditions:
    - If j == 0  print stars for the vertical edges of the M.
    - If j == n - 1 print stars for the vertical edges of the M.
    - If i == j && j<=n/2 print stars for the diagonal from top left to bottom right till middle of the M.
    - If i + j == n - 1 && j >= n / 2 print stars for the diagonal from top right to bottom left till the middle of the M.
    - If none of the conditions are met, print spaces.
3. Print a new line after each row to form the M shape.

E.g. n=13

*           *
**         **
* *       * *
*  *     *  *
*   *   *   *
*    * *    *
*     *     *
*           *
*           *
*           *
*           *
*           *
*           *


*/


using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if (j == 0 || j == n - 1 || (i == j && j <= n / 2) || (i + j == n - 1 && j >= n / 2))
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

/*
OUTPUT:

Enter number of rows: 13

*           *
**         **
* *       * *
*  *     *  *
*   *   *   *
*    * *    *
*     *     *
*           *
*           *
*           *
*           *
*           *
*           *


*/