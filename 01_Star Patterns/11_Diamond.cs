/*
Diamond Pattern:

Approach:
1. Get the number of rows from the user.
2. Calculate the middle point of the diamond using n/2.
3. First half of the diamond:
   - Outer loop iterates from 1 to mid for rows
   - 1st Inner loop prints preceding spaces before the stars. j=mid-i=> max to less spaces as i increases.
   - 2nd inner loop prints stars followed by a space. k<i=> k will interate from 0 to i, so it will print stars equal to the current row number.
   - Print a new line after each row to form the first half of the diamond.
4. Second half of the diamond:
   - Outer loop iterates from mid-1 to 0 for rows
   - 1st Inner loop prints preceding spaces before the stars. j=mid-i=> min to max spaces as i decreases.
   - 2nd inner loop prints stars followed by a space. k<i=> k will interate from 0 to i, so it will print stars equal to the current row number.
   - Print a new line after each row to form the second half of the diamond.

E.g.:
10

    * 
   * * 
  * * * 
 * * * * 
* * * * * 
 * * * * 
  * * * 
   * * 
    *
*/

using System;

public class Diamond
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int mid = n / 2; //e.g. if n=10 then mid=5
        //1st half
        for (int i = 1; i <= mid; i++)
        {
            for (int j = 0; j < mid - i; j++)
            {
                System.Console.Write(" ");
            }
            for (int k = 0; k < i; k++)
            {
                System.Console.Write("* ");
            }
            System.Console.WriteLine();
        }

        //2nd half
        for (int i = mid - 1; i >= 0; i--)
        {
            for (int j = 0; j < mid - i; j++) //E.g. when j<mid-i ==> if mid=5 and i=mid-1 ->5-1=4 eventully when j<mid-i=5-4=1 space so on for each row
            {
                System.Console.Write(" ");
            }
            for (int k = 0; k < i; k++)
            {
                System.Console.Write("* ");
            }
            System.Console.WriteLine();
        }
    }
}

/*

OTUPUT:
Enter number of rows: 
10

    * 
   * * 
  * * * 
 * * * * 
* * * * * 
 * * * * 
  * * * 
   * * 
    *


*/