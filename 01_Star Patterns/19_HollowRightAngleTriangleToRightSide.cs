/*

Hollow right angle triangle aligned to the right side.

Approach:
1. Get the number of rows from the user.
2. Outer loop iterates through each row.
3. The first inner loop checks if the current position is at the bottom edge (i == n-1), on the diagonal (i + j == n - 1), or at the right edge (j == n - 1). If any of these conditions are true, it prints a star; otherwise, it prints a space.
4. Print a new line after each row to form the hollow right angle triangle to the right side.

E.g. n=10

         *
        **
       * *
      *  *
     *   *
    *    *
   *     *
  *      *
 *       *  
**********

*/
using System;

public class HollowRightAngleTriangleToRightSide
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {

            for (int j = 0; j < n; j++)
            {
                if (i == n - 1 || i + j == n - 1 || j == n - 1)
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

Enter number of rows: 10

         *
        **
       * *
      *  *
     *   *
    *    *
   *     *
  *      *
 *       *
**********

*/