/*

// Butterfly Star Pattern:

Approach:

1. Get the number of rows from the user.
2. 1st half of the butterfly:
   - Outer loop iterates from 0 to n for rows.
   - 1st Inner loop prints stars for the left wing.
   - 2nd inner loop prints spaces in between the wings.
   - 3rd inner loop prints stars for the right wing.
   - Print a new line after each row to form the first half of the butterfly.
3. 2nd half of the butterfly:
   - Outer loop iterates from n-2 to 0 for rows.
   - 1st Inner loop prints stars for the left wing.
   - 2nd inner loop prints spaces in between the wings.
   - 3rd inner loop prints stars for the right wing.
   - Print a new line after each row to form the second half of the butterfly.

   E.g. 8   

*              *
**            **
***          ***
****        ****
*****      *****
******    ******
*******  *******
****************
*******  *******
******    ******
*****      *****
****        ****
***          ***
**            **
*              *


*/
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int n = 12;

        System.Console.Write("Enter number of rows: ");
        n = Convert.ToInt32(Console.ReadLine());

        //upper wings
        for (int i = 0; i < n; i++)
        {

            for (int j = 0; j <= i; j++)
            {
                System.Console.Write("*");
            }

            for (int k = 0; k < 2 * (n - i - 1); k++)
            {
                System.Console.Write(" ");
            }

            for (int j = 0; j <= i; j++)
            {
                System.Console.Write("*");
            }

            System.Console.WriteLine();
        }

        //lower wings
        for (int i = n - 2; i >= 0; i--)
        {

            for (int j = 0; j <= i; j++)
            {
                System.Console.Write("*");
            }

            for (int k = 0; k < 2 * (n - i - 1); k++)
            {
                System.Console.Write(" ");
            }

            for (int j = 0; j <= i; j++)
            {
                System.Console.Write("*");
            }

            System.Console.WriteLine();
        }
    }
}

/*
OUTPUT:
Enter number of rows: 8
*              *
**            **
***          ***
****        ****
*****      *****
******    ******
*******  *******
****************
*******  *******
******    ******
*****      *****
****        ****
***          ***
**            **
*              *

*/