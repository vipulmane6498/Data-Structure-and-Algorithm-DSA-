//Box and Cross Inside It:

/*
Approach:
1. Get the number of rows from the user.
2. First outer loop iterates through each row.
3. The first inner loop checks if the current position is on the border of the box (first row, last row, first column, or last column) or on the diagonals (i == j or i + j == n - 1) and prints a star; otherwise, it prints a space.
4. Print a new line after each row to form the box with a cross inside it.
E.g. n=10

**********
**      **
* *    * *
*  *  *  *
*   **   *
*   **   *
*  *  *  *
* *    * *
**      **
**********
*/

using System;

public class BoxAndCrossInsideIt
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter number of rows: ");
        int n = Convert.ToInt32(System.Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {

                //understand below:
                // Check if we are on the border of the box
                // If we are on the 
                // i==0 -> first row, 
                // i==n-1 -> last row, 
                // j==0 -> first column, 
                // j==n-1 -> last column, print a star
                //e.g. when i=0 and j=1 it means we are on the first row and second column, so we print a star here in we just needunderstand that if one condition is true and other do not satisfy(true || false || false || false -> true) we can print a star.

                //Iterations for Box->
                //i=0 -> print * on first row as following condition is true in (i == 0 || j == 0 || i == n - 1 || j == n - 1)
                //i=1(2nd row) and j=0 -> print * on first column
                //i=1(2nd row) and j=1,2,3,4,5,6,7,8 -> print space on 2nd row and second column so on..
                //i=1(2nd row) and j=n-1 -> print * on last column 
                //i=2(3rd row) and j=0 -> print * on first column
                //i=2(3rd row) and j=1,2,3,4,5,6,7,8 -> print space on 2nd row and second column so on..
                //i=3(3rd row) and j=n-1 -> print * on last column  
                //hence for every row j==0 and j==n-1 satisfy the condition and print a star till the last row
                //and when i=n-1 (last row) it will print stars on all columns as the condition i == n - 1 will be true for all columns.


                //Iterations for Cross(i==j || i+j=n-1)->
                //i==j
                //When we say i==j means we are on the main diagonal of the box, so we print a star. e.g. it will print star when i=0 and j=0, i=1 and j=1, i=2 and j=2, so on till the last row.

                //i+j==n-1 
                //i+j==n-1 means we are on the anti-diagonal of the box, so we print a star. e.g. it will print star when i=0 and j=9, i=1 and j=8, i=2 and j=7, so on till the last row. 
                // e.g. we used condition i+j=n-1  
                // 1st part i+j ==>when i=2 and when j=7 ==> i+j=2+7=9, and 
                // 2nd part n-1 => n=10 so n-1 => 10-1=9 
                // last => from i+j=9 and n-1=9 => 9=9 condition satisfy at position when j=7 hence star will print at j=7 column and so on for other rows.


                if (i == 0 || j == 0 || i == n - 1 || j == n - 1 || i == j || i + j == n - 1)
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
Enter number of rows: 
10
**********
**      **
* *    * *
*  *  *  *
*   **   *
*   **   *
*  *  *  *
* *    * *
**      **
**********

*/