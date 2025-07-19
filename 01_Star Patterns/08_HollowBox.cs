
/*
Hollow Box Pattern:

Approach:
1. Get the number of rows from the user.
2. First outer loop iterates through each row.
3. The first inner loop checks if the current position is on the border of the box (first row, last row, first column, or last column) and prints a star; otherwise, it prints a space.
4. Print a new line after each row to form the box.
E.g. n=10
**********
*        *
*        *
*        *
*        *
*        *
*        *
*        *
*        *
**********

*/



using System;

public class HollowBox
{
    public static void Main(string[] args)
    {
        System.Console.WriteLine("Enter the number of rows: ");
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

                //Iterations->
                //i=0 -> print * on first row as following condition is true in (i == 0 || j == 0 || i == n - 1 || j == n - 1)
                //i=1(2nd row) and j=0 -> print * on first column
                //i=1(2nd row) and j=1,2,3,4,5,6,7,8 -> print space on 2nd row and second column so on..
                //i=1(2nd row) and j=n-1 -> print * on last column 
                //i=2(3rd row) and j=0 -> print * on first column
                //i=2(3rd row) and j=1,2,3,4,5,6,7,8 -> print space on 2nd row and second column so on..
                //i=3(3rd row) and j=n-1 -> print * on last column  
                //hence for every row j==0 and j==n-1 satisfy the condition and print a star till the last row
                //and when i=n-1 (last row) it will print stars on all columns as the condition i == n - 1 will be true for all columns.

                if (i == 0 || j == 0 || i == n - 1 || j == n - 1)
                {
                    System.Console.Write("*");
                }
                else // If we are not on the border, print a space
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
Enter the number of rows: 
10
**********
*        *
*        *
*        *
*        *
*        *
*        *
*        *
*        *
**********

*/


    