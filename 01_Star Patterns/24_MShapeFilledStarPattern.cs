/*
M Shape Filled Star Pattern

Approach:
1. Get the number of rows (height of the M) from the user.
2. Outer loop iterates through each row.
    3. The first inner loop prints stars for the first right angle triangle.
    4. The second inner loop prints spaces in the middle.
    5. The third inner loop prints stars for the second right angle triangle.
6. Print a new line after each row to form the M shape.

E.g. n=10:

*                *
**              **
***            ***
****          ****
*****        *****
******      ******
*******    *******
********  ********
******************

*/

using System;

public class MShapeFilledStarPattern
{
    public static void Main(string[] args)
    {

        // Height of the M
        Console.Write("Enter number of rows: ");
        int n = Convert.ToInt32(Console.ReadLine());

        //We have to print star for 1st right angle triangle,  in the middle spaces then stars for second mirrored right angle triangle on the same row loop
        //On 1st Row:
        // 1. print stars for 1st right angle triangle on 1st row
        // 2. print spaces in the middle on the 1st row: (2 * (n - i - 1)) spaces in the middle
        // 3. After spaces print stars for 2nd right angle triangle on same  1st row
        // On 2nd Row:
        //  *(star)------(space)------*(star) on 2nd row and so on for next rows

        for (int i = 0; i < n; i++) //this outer loop runs for n rows
        {
            // Print stars for the first right angle triangle
            for (int j = 0; j < i; j++)
            {
                System.Console.Write("*");
            }

            // Print spaces in the middle
            int space = 2 * (n - i - 1);
            for (int k = 0; k < space; k++)
            {
                System.Console.Write(" ");
            }
            // Print stars for the second right angle triangle
            for (int j = 0; j < i; j++)
            {
                System.Console.Write("*");
            }
            System.Console.WriteLine();
        }
    }
}
/*

OUTPUT:
Enter number of rows: 10

*                *
**              **
***            ***
****          ****
*****        *****
******      ******
*******    *******
********  ********
******************


*/