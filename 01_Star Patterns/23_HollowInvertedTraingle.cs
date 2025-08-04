/*
Hollow Inverted Triangle Pattern

Approach:
1. Get the number of rows from the user.
2. Outer loop iterates through each row.
3. The first inner loop prints leading spaces to create the inverted effect.
4. The second inner loop prints stars at the edges of the triangle and spaces in between for the hollow effect.
   a. i==0: prints stars for the first row to form the base of the triangle.
   b. j==0: prints the first star of the row.
   c. j==totalCols - 1: prints the last star of the row.
5. Print a new line after each row to form the hollow inverted triangle.

E.g. n=10

*******************
 *               *
  *             *
   *           *
    *         *
     *       *
      *     *
       *   *
        * *
         *
*/

using System;

public class HollowInvertedTraingle
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < i; k++)
            {
                System.Console.Write(" ");
            }

            int totalCols = 2 * (n - i) - 1;

            for (int j = 0; j < totalCols; j++)
            {
                if (i == 0 || j == 0 || j == totalCols - 1)
                {
                    System.Console.Write("*");
                }
                else
                {
                    System.Console.Write(" ");
                }
            }
            System.Console.WriteLine();
        }
    }
}

/*
Output:

Enter number of rows: 10

*******************
 *               *
  *             *
   *           *
    *         *
     *       *
      *     *
       *   *
        * *
         *


*/