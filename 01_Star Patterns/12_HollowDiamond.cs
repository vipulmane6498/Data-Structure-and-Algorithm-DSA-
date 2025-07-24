
/*
Hollow Diamond Pattern:


Approach:
1. Get the number of rows from the user.
2. Calculate the middle point of the diamond using n/2.
3. First half of the diamond:
   - Outer loop iterates from 0 to mid for rows.
   - 1st Inner loop prints preceding spaces before the stars. j<mid-i => decreasing preceding spaces as i increases.
   - 2nd inner loop prints stars at the beginning and end of each row, with spaces in between. j==0 or j==2*i => print star at the start and end of the row.
   - Print a new line after each row to form the first half of the diamond.
4. Second half of the diamond:
   - Outer loop iterates from mid-1 to 0 for rows.
   - 1st Inner loop prints preceding spaces before the stars. j<mid-i => increasing preceding spaces as i decreases.
   - 2nd inner loop prints stars at the beginning and end of each row, with spaces in between. j==0 or j==2*i => print star at the start and end of the row.
   - Print a new line after each row to form the second half of the diamond.


   E.g. 
    n=10

     *
    * *
   *   *
  *     *
 *       *
*         *
 *       *
  *     *
   *   *
    * *
     *
*/






using System;

public class HollowDiamond
{
    public static void Main(string[] args)
    {
          System.Console.WriteLine("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int mid = n / 2;

        // Upper half
        for (int i = 0; i <= mid; i++)
        {
            for (int j = 0; j < mid - i; j++) //j<mid-i => decreasing preceeding spaces as i increases
            {
                Console.Write(" "); //
            }

            for (int j = 0; j < 2*i+1; j++)  //j<2*i+1 => increasing loop
            {
                 //Two star for each row
                //1st j==0 -> after preceding spaces(j=<mid-i) then 1st star for the row
                //2nd j==2*i -> last star for the row e.g. when i=2 => means 2*i->2*2=4 and when j becomes 4 ->  j=4 hence j==2*i ==> 4==4 hence when j=4 this condition satisfied hence start will be printed at j=4 and so on for next rows
                if (j == 0 || j == 2 * i)
                    Console.Write("*");
                else
                    Console.Write(" ");
            }
            Console.WriteLine();
        }

        // Lower half
        for (int i = mid - 1; i >= 0; i--)
        {
            for (int j = 0; j < mid - i; j++) //j<mid-i => increasing preceeding spaces as i decreases
            {
                Console.Write(" ");
            }

            for (int j = 0; j < 2 * i + 1; j++) //j<2*i+1 => increasing loop
            {
                //Two star for each row
                //1st j==0 -> after preceding spaces(j=<mid-i) then 1st star for the row
                //2nd j==2*i -> last star for the row e.g. when i=2 => means 2*i->2*2=4 and when j becomes 4 ->  j=4 hence j==2*i ==> 4==4 hence when j=4 this condition satisfied hence start will be printed at j=4 and so on for next rows
                if (j == 0 || j == 2 * i)
                    Console.Write("*");
                else
                    Console.Write(" "); //else blank spaces
            }
            Console.WriteLine();
        }
    }
}

/*
OUTPUT:
Enter number of rows:
10
     *
    * *
   *   *
  *     *
 *       *
*         *
 *       *
  *     *
   *   *
    * *
     *

*/

