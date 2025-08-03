/*
Hollow Equilateral Triangle Pattern

Approach:
1. Get the number of rows from the user.
2. Outer loop iterates through each row.
3. The first inner loop prints leading spaces to center the triangle.
4. The second inner loop prints stars at the edges of the triangle and spaces in between for hollow effect.
    a. j==0: prints the first star of the row.
    b. j==2*i: prints the last star of the row.
    c. i == n-1: prints stars for the last row to form the base of the triangle.
5. Print a new line after each row to form the hollow equilateral triangle.


E.g.n=10

          *
         * *
        *   *
       *     *
      *       *
     *         *
    *           *
   *             *
  *               *
 *******************

*/

using System;

public class HollowEquilateralTriangle
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int k = 0; k < n - i; k++)
            {
                System.Console.Write(" ");
            }

            for (int j = 0; j <= 2 * i; j++)
            {
                if (j == 0 || j == 2 * i || i == n - 1)
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
OUTPUT:
Enter number of rows: 10
          *
         * *
        *   *
       *     *
      *       *
     *         *
    *           *
   *             *
  *               *
 *******************


*/