/*

Inverted Traingle

Approach:

1. Get the number of rows from the user.
2. First outer loop iterates through each row.
3. The first inner loop prints spaces to align the stars in an equilateral triangle.( j <i) => this will add min spaces in the first row and increase by one space in each subsequent row.
4. The second inner loop prints stars for the current row. (k<n-i) => this will print max stars in the first row and decrease by one star in each subsequent row.
5. Print a new line after each row to form the triangle.


*/
using System;

public class InvertedTraingle
{
    public static void Main(string[] args)
    {

        //1. Get the number of rows from the user.
        System.Console.WriteLine("Enter a number for rows: ");
        int n = Convert.ToInt32(System.Console.ReadLine());


        //2. First outer loop iterates through each row.
        for (int i = 0; i < n; i++)
        {

            //3. The first inner loop prints spaces to align the stars in an equilateral triangle.( j <i) => this will add min spaces in the first row and increase by one space in each subsequent row.
            for (int j = 0; j < i; j++)
            {
                System.Console.Write(" ");
            }

            //4. The second inner loop prints stars for the current row. (k<n-i) => this will print max stars in the first row and decrease by one star in each subsequent row.
            for (int k = 0; k < n - i; k++)
            {
                System.Console.Write(" *");
            }

            //5. Print a new line after each row to form the triangle.
            System.Console.WriteLine();
        }
    }
}

/*

Enter a number for rows: 
10
 * * * * * * * * * *
  * * * * * * * * *
   * * * * * * * *
    * * * * * * *
     * * * * * *
      * * * * *
       * * * *
        * * *
         * *
          *
*/
