/*
Numbers in Diamond Pattern:

Approach:
1. Get the number of rows from the user.
2. Calculate the middle point of the diamond using n/2.  
3. First upper half of the diamond:
    - Outer loop iterates from 1 to mid for rows
    - 1st Inner loop prints preceding spaces before the numbers. j=mid-i=> max to less spaces as i increases.
    - 2nd inner loop prints numbers followed by a space. k<i=> k will interate from 1 to i, so it will print numbers equal to the current row number.
    - 3rd inner loop prints numbers in reverse order. m=i-1=> m will interate from i-1 to 1, so it will print numbers equal to the current row number.
    - Print a new line after each row to form the first half of the diamond.
4. Second lower half of the diamond:
    - Outer loop iterates from mid-1 to 1 for rows
    - 1st Inner loop prints preceding spaces before the numbers. j=mid-i=> min to max spaces as i decreases.
    - 2nd inner loop prints numbers followed by a space. k<i=> k will interate from 1 to i, so it will print numbers equal to the current row number.
    - 3rd inner loop prints numbers in reverse order. m=i-1=> m will interate from i-1 to 1, so it will print numbers equal to the current row number.
    - Print a new line after each row to form the second half of the diamond.

E.g.: 10

    1
   121
  12321
 1234321
123454321
 1234321
  12321
   121
    1

*/

using System;

public class Diamond
{
    public static void Main(string[] args)
    {
        Console.Write("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int mid=n/2;
        
        //upper half 
        for (int i = 1; i <= mid; i++)
        {

            //starting preceeding spaces
            for (int j = 1; j <= mid - i; j++)
            {
                System.Console.Write(" ");
            }

            //left side
            for (int k = 1; k <= i; k++)
            {
                System.Console.Write(k);
            }
            //right side

            for (int m = i - 1; m >= 1; m--)
            {
                System.Console.Write(m);
            }
            System.Console.WriteLine();
        }
        
        //lower half -> will reverse the upper half
        for (int i = mid - 1; i >= 1; i--)
        {
            //Starting preceeding spaces
            for (int j = 1; j <= mid - i; j++)
            {
                System.Console.Write(" ");
            }

            //left side
            for (int k = 1; k <= i; k++)
            {
                System.Console.Write(k);
            }
            //right side

            for (int m = i - 1; m >= 1; m--)
            {
                System.Console.Write(m);
            }
            System.Console.WriteLine();
        }
 
    }
}

/*
OUTPUT:
Enter number of rows: 0
    1
   121
  12321
 1234321
123454321
 1234321
  12321
   121
    1


*/